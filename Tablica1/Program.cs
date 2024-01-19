using System;

class Program
{
    static void Main()
    {
        // Tworzenie tablicy jednowymiarowej o nazwie tablica1
        int[] tablica1 = new int[10];

        // Wypełnianie tablicy liczbami od 0 do 9
        for (int i = 0; i < 10; i++)
        {
            tablica1[i] = i;
        }

        // Wyświetlanie zawartości tablicy
        Console.WriteLine("Zawartość tablicy1:");
        foreach (int liczba in tablica1)
        {
            Console.Write(liczba + " ");
        }

        // Jeśli chcesz zobaczyć reprezentację graficzną tablicy, możesz użyć poniższej linii:
        // Console.WriteLine(string.Join(" ", tablica1));
    }
}
