using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace TSP
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //Initialize Variable
        Population currentPopulation ;
        Population nextGeneration;
        int generation = 0;
        bool terminate = false;
        int sameFitness = 0;

        // Initialize Design Variable
        Pen pen = new Pen(Color.DarkRed, 7);
        Pen bluePen = new Pen(Color.Blue, 2);
        Brush aBrush = (Brush)Brushes.Black;
        Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

        public Form1()
        {
                InitializeComponent();
                
        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            //INITIALIZATION
            currentPopulation = Population.initializePop();

            lblStatus.Text = "Ongoing";
            InitalizeBtn.Enabled = false;
            StartBtn.Enabled = false;
            while (!terminate)
            {

                //Sort current population according to fitness : Fitness-Based Selection
                currentPopulation = Population.sortSelection(currentPopulation);

                Thread.Sleep(500);
                //Display
                lblGen.Text = (generation + 1).ToString();
                lblBestFit.Text = currentPopulation.P[0].Fitness.ToString();
                lblChromosome.Text = "";
                lblTerminate.Text = sameFitness.ToString();
                for (int i = 0; i < currentPopulation.P[0].T.Count; i++)
                    lblChromosome.Text += currentPopulation.P[0].T[i].City_ID.ToString();
           
                MapPanel.Refresh();

                //Create next generation from current population by undergoing crossover and mutation
                nextGeneration = Population.genNewPop(currentPopulation);

                // Replace chromosome duplication by checking fitness
                nextGeneration = Population.removeDuplication(nextGeneration);

                //Sort the new generation according to fitness again
                nextGeneration = Population.sortSelection(nextGeneration);

                // Termination Criteria:
                // If Fitness is the same for 20 consecutive generation, then terminate
                if (nextGeneration.P[0].Fitness == currentPopulation.P[0].Fitness)
                {
                    sameFitness++;
                    if (sameFitness == 21)
                    {
                        terminate = true;
                        break;
                    }
                }
                else
                    sameFitness = 0;

                //After that, make current Population = next generation
                currentPopulation = nextGeneration;
                generation++;
            }
            lblStatus.Text = "Completed";
            InitalizeBtn.Enabled = true;
        }
        private void InitializeBtn_Click(object sender, EventArgs e)
        {
            //Reinitiate 
            StartBtn.Enabled = true;
            generation = 0;
            terminate = false;
            sameFitness = 0;

            lblGen.Text = "0";
            lblChromosome.Text = "0";
            lblBestFit.Text = "0";
            lblStatus.Text = "Not started";
            lblTerminate.Text = "0";

            currentPopulation = null;
            MapPanel.Refresh();
        }

        //Display
        private void MapPanel_Paint(object sender, PaintEventArgs e)
        {
            GroupBox2.Enabled = true;
            e.Graphics.DrawEllipse(pen, 350, 370, 7, 7);   // KL
            e.Graphics.DrawEllipse(pen, 415, 77, 7, 7);    // Kota bahru
            e.Graphics.DrawEllipse(pen, 515, 305, 7, 7);   // Kuantan
            e.Graphics.DrawEllipse(pen, 240, 75, 7, 7);    // Alor Setar
            e.Graphics.DrawEllipse(pen, 385, 405, 7, 7);   // Seremban
            e.Graphics.DrawEllipse(pen, 420, 451, 7, 7);   // Melaka
            e.Graphics.DrawEllipse(pen, 280, 215, 7, 7);   // Ipoh
            e.Graphics.DrawEllipse(pen, 214, 129, 7, 7);   // Georgetown

            // Create array of points that define lines to draw.
            Point[] points =
            {
                 new Point(350,370),
                 new Point(415, 77),
                 new Point(515,305),
                 new Point(240,75),
                 new Point(385,405),
                 new Point(420,451),
                 new Point(280,215),
                 new Point(214,129),
             };

            e.Graphics.DrawString("Kuala Lumpur", font, aBrush, 350,350);
            e.Graphics.DrawString("Kota Bahru", font, aBrush, 430, 73);
            e.Graphics.DrawString("Kuantan", font, aBrush, 530, 300);
            e.Graphics.DrawString("Alor Setar", font, aBrush, 257, 70);
            e.Graphics.DrawString("Seremban", font, aBrush, 395, 395);
            e.Graphics.DrawString("Melaka", font, aBrush, 430, 447);
            e.Graphics.DrawString("Ipoh", font, aBrush, 290, 200);
            e.Graphics.DrawString("Georgetown", font, aBrush, 145, 110);

            if (currentPopulation == null)
                return;

            for (int i = 0; i < currentPopulation.P[0].T.Count - 1; i++)
            {
                int city1 = currentPopulation.P[0].T[i].City_ID;
                int city2 = currentPopulation.P[0].T[i+1].City_ID;
                e.Graphics.DrawLine(bluePen, points[city1], points[city2]);
            }
               
        }
    }

    public static class Env
    {
        //Enviroment class contains the global variable of constant data
        public const int POPULATION_SIZE = 100;
        public const int NO_OF_CITIES = 8;
        public const int ELITISM = 10;          // Elitism is 10/100 = 10%
        public const double MUTRATE = 0.1;

        public static int[,] DISTANCE_BETWEEN_CITIES = new int[8, 8]
            {       {0   , 338 , 196 , 362 , 54  , 121 , 174 , 357},
                {338 , 0   , 285 , 208 , 380 , 438 , 215 , 225},
                {196 , 285 , 0   , 417 , 195 , 216 , 263 , 376},
                {362 , 208 , 417 , 0   , 416 , 484 , 189 , 118},
                {54  , 380 , 195 , 416 , 0   , 68  , 227 , 429},
                {121 , 438 , 216 , 484 , 68  , 0   , 295 , 512},
                {174 , 215 , 263 , 189 , 227 , 295 , 0   , 124},
                {357 , 225 , 376 , 118 , 429 , 512 , 124 , 0  },
            };
    }
}
