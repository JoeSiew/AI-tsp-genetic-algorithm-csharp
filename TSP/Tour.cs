using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TSP
{
    //Tour is the chromosome in permutation encoded format
    //For example, [0,1,2,3,4,5,6,7,8,0] = [KL,Kota Bahru,Kuantan,Alor Setar,Seremban,Melaka,Ipoh,Georgetown,KL]
    //As its permutation, the id only come out once. However can have many different route.
    public class Tour
    {
        //instance variable
        private List<City> t;       //tour is chromosome, hence t[0] is chromosome1, t[1] is chromosome2 and ....
        private double fitness;

        //constructor
        public Tour(List<City> chromosome)
        {
            this.t = chromosome;
            this.fitness = calcFitness();
        }
        //properties
        public List<City> T
        {
            get { return t; }
            set { t = value; }
        }

        public double Fitness
        {
            get { return fitness; }
        }

        //Function

        //PERMUTATION ENCODING
        public static Tour create_gnome(int noCities)
        {
            //create random chromosome by using permutation encoding
            List<City> t = new List<City>();

            //Following function is to create number that will not duplicate
            // the idea is chromosome always starts from [0] and end with [0]
            City c = new City(0);
            t.Add(c); //First gene starting from KL

            //Random number generator with no repetition
            List<int> listNumbers = new List<int>();
            int number;
            for (int i = 0; i < noCities - 1; i++)
            {
                do
                {
                    number = Program.r.Next(1, 8);
                } while (listNumbers.Contains(number));

                listNumbers.Add(number);
                c = new City(listNumbers[i]);
                t.Add(c);
            }
            c = new City(0);
            t.Add(c); //Last gene ending at KL

            return new Tour(t);

        }

        //MUTATION OPERATOR
        public Tour mutate_genes()
         {
            //since this is a permutation based encoding, Swap Mutation Operator is used
            List<City> tmp = new List<City>(this.t);
            if (Program.r.NextDouble() < Env.MUTRATE)
            {
                //Only swap the cities in between
                int i = Program.r.Next(1, this.t.Count-1);
                int j = Program.r.Next(1, this.t.Count-1);
                City v = tmp[i];
                tmp[i] = tmp[j];
                tmp[j] = v;
            }

            return new Tour(tmp);
        }

        //ORDERED CROSSOVER
        public Tour mate(Tour parent2)
        {
            // Ordered crossover way is used
            List<City> child_Chromosome = new List<City>();
            double length = t.Count;
            double p = Program.r.Next(0, 1);

            // 50% chance of parent 1 gene being more dominant than parent 2
            if (p <= 0.5)
            {
                // Add first 5 city from parent1 : [0,1,2,3,4]  
                for (int k = 0; k < Math.Round((length / 2), MidpointRounding.AwayFromZero); k++)
                    child_Chromosome.Add(this.t[k]);

                // Add the remaining city from parent2 in order by checking for no repetition of city
                for (int i = 0; i < 9; i++)
                {
                    //if child chromosome did not contain the city, then add parent2 in order
                    int j = parent2.t[i].City_ID;
                    City gene = parent2.t[i];
                    bool isExist = child_Chromosome.Exists(l => l.City_ID == j);

                    if (isExist == false)
                        child_Chromosome.Add(gene);
                }

            }
            else
            {
                // Add first 5 city from parent2 : [0,1,2,3,4]  
                for (int k = 0; k < Math.Round((length / 2), MidpointRounding.AwayFromZero); k++)
                    child_Chromosome.Add(parent2.t[k]);

                // Add the remaining city from parent1 in order by checking for no repetition of city
                for (int i = 0; i < 9; i++)
                {
                    //if child chromosome did not contain the city, then add parent2 in order
                    int j = this.t[i].City_ID;
                    City gene = this.t[i];
                    bool isExist = child_Chromosome.Exists(l => l.City_ID == j);

                    if (isExist == false)
                        child_Chromosome.Add(gene);
                }

            }
            //Last destination is [0] = Kuala Lumpur
            child_Chromosome.Add(new City(0));
            return new Tour(child_Chromosome);
        }

        private double calcFitness()
        {
            //Note that the lower the distance, the better the fitness
            //Distance is the distance travel of all points from KL back to KL
            int length = this.t.Count();
            double fitness , distance = 0;

            for (int i = 0; i < length - 1; i++)
            {
                int city1 = this.t[i].City_ID;
                int city2 = this.t[i + 1].City_ID;
                distance += Env.DISTANCE_BETWEEN_CITIES[city1, city2];
            }
            fitness = distance;
            return fitness;
        }
    }
}
