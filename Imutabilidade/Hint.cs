using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imutabilidade
{
    public class Hint
    {
        public string Name { get; }
        public double MutationRate { get; }

        public Hint(string name, double mutationRate)
        {
            Name = name;
            MutationRate = mutationRate;
        }

        public Hint Mutate(double mutationRate)
        {
            return new Hint(Name, mutationRate);
        }

        //public void ApplyMutation(IList<Hint> arrayToMutate, double mutationRate, int ignore)
        //{
        //    for (int i = ignore; i < arrayToMutate.Count; i++)
        //    {
        //        arrayToMutate[i] = arrayToMutate[i].Mutate(mutationRate);
        //    }
        //}

        //60% of Performance improvement 
        public void ApplyMutation(IList<Hint> arrayToMutate, double mutationRate, int ignore)
        {
            Parallel.For(ignore, arrayToMutate.Count, (i) =>
            {
                arrayToMutate[i] = arrayToMutate[i].Mutate(mutationRate);
            });
        }

        //public void FillWithCrossovers(IList<Hint> arrayToFill)
        //{
        //    for (int i = 0; i < arrayToFill.Count; i++)
        //    {
        //        if (arrayToFill[i] != null) continue;
        //        var parent1 = PickUsingTournament();
        //        var parent2 = PickUsingTournament();
        //        arrayToFill[i] = parent1.CrossOver(parent2);
        //    }
        //}


        //60% of Performance improvement 
        public void FillWithCrossovers(IList<Hint> arrayToFill)
        {
            Parallel.For(0, arrayToFill.Count, (i) =>
            {
                if (arrayToFill[i] != null) return;
                var parent1 = PickUsingTournament();
                var parent2 = PickUsingTournament();
                arrayToFill[i] = parent1.CrossOver(parent2);
            });
        }

        private Hint CrossOver(Hint parent2)
        {
            return new Hint(Name, parent2.MutationRate);
        }

        private static Hint PickUsingTournament()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, 4);
            double mutation = rnd.Next(1, 13);

            IEnumerable<string> names = new List<string>() { "first", "second", "third", "fourth", "fifth" };
            Hint result = new Hint(names.ElementAt(index), mutation);

            return result;
        }
    }
}
