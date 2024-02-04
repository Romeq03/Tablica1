using System;

class Program
{
    static void Main()
    {
        int[] tablica1 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            tablica1[i] = i;
        }

        Console.WriteLine("Zawartość tablicy1:");
        foreach (int liczba in tablica1)
        {
            Console.Write(liczba + " ");
        }

    }
}
