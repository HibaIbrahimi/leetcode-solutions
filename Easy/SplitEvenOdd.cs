using System.Collections.Generic;

public class ListExercises
{
    public static void SplitEvenOdd(List<int> input, out List<int> listEven, out List<int> listOdd)
    {
        listEven = new List<int>();
        listOdd = new List<int>();

        // 1️⃣ Séparation
        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] % 2 == 0)
            {
                listEven.Add(input[i]);
            }
            else
            {
                listOdd.Add(input[i]);
            }
        }

        // 2️⃣ Tri
        listEven.Sort();
        listOdd.Sort();
    }
}
