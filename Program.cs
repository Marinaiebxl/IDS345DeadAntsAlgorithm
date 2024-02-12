using System;
using System.Text;

namespace IDS345DeadAntsAlgorithm;

internal class Program
{
    static void Main(string[] args)
    {
        string Ants = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
        string AntStampede = " ...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

        int AliveBefore = Ants.Count(c => c == '.');
        int AliveAfter = AntStampede.Count(c => c == '.');

        int Deadants = AliveBefore - AliveAfter;
        Console.WriteLine(Deadants);
        Console.ReadLine();




    }
}
