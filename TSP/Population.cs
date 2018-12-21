using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TSP
{
    public class Population
    {
        //Instance variable
        private List<Tour> p;

        //Constructor
        public Population(List<Tour> pop)
        {
            this.p = pop;
        }


        //Properties
        public List<Tour> P
        {
            get { return p; }
            set { p = value; }
        }

        //Functions

        // Initialize Population of 100 chromosome
        public static Population initializePop()
        {
            List<Tour> temp = new List<Tour>();

            for (int i = 0; i < Env.POPULATION_SIZE; i++)
            {
                Tour gnome = Tour.create_gnome(Env.NO_OF_CITIES);
                temp.Add(gnome);
            }
            return new Population(temp);
        }

        //Generate new population from current population
        public static Population genNewPop(Population currentPopulation)
        {
            List<Tour> newPop = new List<Tour>();

            //Perform Elitism, that means 10% of fittest population goes to next generation
            int k = (Env.ELITISM * Env.POPULATION_SIZE / 100);
            for (int i = 0; i < k; i++)
            {
                newPop.Add(currentPopulation.p[i]);
            }

            //Remaing 90% of next generation is produced by offspring
            int j = ((100 - Env.ELITISM) * Env.POPULATION_SIZE / 100);

            // From 50% of fittest population, chromosome will mate to produce offspring
            for (int i = 0; i < j; i++)
            {
                int randNo = Program.r.Next(0, Env.POPULATION_SIZE / 2);
                Tour parent1 = currentPopulation.p[randNo];
                randNo = Program.r.Next(0, Env.POPULATION_SIZE / 2);
                Tour parent2 = currentPopulation.p[randNo];
                Tour offspring = parent1.mate(parent2);

                //Probability that the new offspring has mutation
                offspring = offspring.mutate_genes();

                newPop.Add(offspring);
            }
            return new Population(newPop);
        }

        //FITNESS BASED SELECTION
        //Sort Population ascending order according to fitness: lower fitness = better due to lower distance
        public static Population sortSelection(Population pop)
        {
            List<Tour> SortedPopulation = pop.p.OrderBy(population => population.Fitness).ToList();
            return new Population(SortedPopulation);
        }

        //REMOVE DUPLICATION OF CHROMOSOME
        public static Population removeDuplication(Population pop)
        {
            //Remove chromosome duplication by checking fitness
            List<Tour> RemoveDuplication = pop.p.GroupBy(x => x.Fitness).Select(x => x.First()).ToList();
            while (RemoveDuplication.Count < Env.POPULATION_SIZE)
            {
                //Crossover new offspring to replace the duplicated chromosome
                int len = RemoveDuplication.Count;
                int randNo = Program.r.Next(0, len - 1);
                Tour parent1 = pop.p[randNo];
                randNo = Program.r.Next(0, len - 1);
                Tour parent2 = pop.p[randNo];

                Tour offspring = parent1.mate(parent2);
                offspring = offspring.mutate_genes();
                RemoveDuplication.Add(offspring);
            }
            return new Population(RemoveDuplication);
        }

    }
}
