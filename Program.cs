//PROGRAMA AVES BALBUENA
using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        List<string> aves = new List<string> { "Loro gris", "paloma de diamante", "coctel" };
        Console.WriteLine("los valores de la lista antes de insertar:");
        foreach (string ave in aves)
        {
            Console.Write(ave + "");
        }
        Console.WriteLine();
        aves.Add("mayna");
        aves.Add("periquitos");
        aves.Add("cactua");

        Console.WriteLine("los valores de la lista despues de insertar:");

        foreach (string ave in aves)
        {
            Console.Write(ave + "");
        }
        Console.WriteLine();
    }
}
