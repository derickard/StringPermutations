using System;

namespace StringPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] atoms = new string[] { "ant", "bat", "cow", "cow" };
            StringPerm p = null;
            Console.WriteLine("All permutations are:\n");
            for (int k = 0; (ulong)k < StringPerm.FactorialLookup(4); ++k)
            {
                p = new StringPerm(atoms, k);
                Console.WriteLine(k + " " + p.ToString());
            }
        }
    }
}
