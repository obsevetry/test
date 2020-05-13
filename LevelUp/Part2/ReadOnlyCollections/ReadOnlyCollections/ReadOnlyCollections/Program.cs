﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReadOnlyCollections
{
    class Program
    {
        public static void Main()
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");

            ReadOnlyCollection<string> readOnlyDinosaurs =
                new ReadOnlyCollection<string>(dinosaurs);

            Console.WriteLine();
            foreach (string dinosaur in readOnlyDinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nCount: {0}", readOnlyDinosaurs.Count);

            Console.WriteLine("\nContains(\"Deinonychus\"): {0}",
                readOnlyDinosaurs.Contains("Deinonychus"));

            Console.WriteLine("\nreadOnlyDinosaurs[3]: {0}",
                readOnlyDinosaurs[3]);

            Console.WriteLine("\nIndexOf(\"Compsognathus\"): {0}",
                readOnlyDinosaurs.IndexOf("Compsognathus"));

            ((IList<string>)readOnlyDinosaurs).Add("mnkjhkjh");

            Console.WriteLine("\nInsert into the wrapped List:");
            Console.WriteLine("Insert(2, \"Oviraptor\")");
            dinosaurs.Insert(2, "Oviraptor");



            Console.WriteLine();
            foreach (string dinosaur in readOnlyDinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            string[] dinoArray = new string[readOnlyDinosaurs.Count + 2];
            readOnlyDinosaurs.CopyTo(dinoArray, 1);

            Console.WriteLine("\nCopied array has {0} elements:",
                dinoArray.Length);
            foreach (string dinosaur in dinoArray)
            {
                Console.WriteLine("\"{0}\"", dinosaur);
            }

            Console.ReadKey();
        }
    }
}
