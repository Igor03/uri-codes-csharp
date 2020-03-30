using System;
using System.Collections.Generic;

namespace _2958
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lifeProblems = new List<string>();
            List<string> disciplineProblems = new List<string>();
            string[] line = Console.ReadLine().Split(' ');
            int rows = int.Parse(line[0]);
            int columns = int.Parse(line[1]);
            int countLifeProblems, countDisciplineProblems;

            for (int i = 0; i < rows; i++)
            {
                foreach (string p in Console.ReadLine().Split(' '))
                {
                    if (p.Contains("V"))
                        lifeProblems.Add(p);
                    else
                        disciplineProblems.Add(p);
                }
            }

            lifeProblems.Sort();
            disciplineProblems.Sort();
            countLifeProblems = lifeProblems.Count;
            countDisciplineProblems = disciplineProblems.Count;

            for (int i=0; i < countLifeProblems; i++)            
                Console.WriteLine(lifeProblems[countLifeProblems-1-i]);            
            for (int i = 0; i < countDisciplineProblems; i++)            
                Console.WriteLine(disciplineProblems[countDisciplineProblems-1-i]);

            //disciplineProblems.ForEach(problem => lifeProblems.Add(problem));

            //foreach (string problem in lifeProblems)
            //    Console.WriteLine(problem);

            Console.ReadLine();
        }
    }
}
