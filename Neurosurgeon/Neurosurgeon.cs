using System;

namespace Neurosurgeon
{
    class Neurosurgeon : ISurgeon
    {
        public string name { get; private set; }

        private int cost_of_surgery;

        public int cost
        {
            get 
            { 
                return cost_of_surgery; 
            }
            set 
            {
                if (value < 0)
                {
                    cost_of_surgery = 0;
                    return;
                }

                cost_of_surgery = value; 
            }
        }


        public static int k_neurosurgeons { get; private set; } = 0;


        public Neurosurgeon(string name, int cost)
        {
            this.cost = cost;
            this.name = name;
            k_neurosurgeons += 1;
        }

        public Neurosurgeon()
        {
            this.name = "Ivan";
            this.cost = 25;
            k_neurosurgeons += 1;
        }

        public void take_money(int some_money)
        {
            if (some_money >= cost)
                Console.WriteLine("Thank you very much!");
            else
                Console.WriteLine("Sorry, but you need more money(");
        }

        public void make_inspection()
        {
            Console.WriteLine("We've made an inspection, you should have a surgeon!! " +
                $"Dr. {name} can do it for $ {cost}");
        }

        public void make_surgery(string patient_name)
        {
            Console.WriteLine($"The surgery for {patient_name} was successful!!");
        }

        public void make_surgery()
        {
            Console.WriteLine("The surgery was successful!!!");
        }

        public override string ToString()
        {
            return $"Dr. {name}, surgery cost – {cost}";
        }

    }
}
