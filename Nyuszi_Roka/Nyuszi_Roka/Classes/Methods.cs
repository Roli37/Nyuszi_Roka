using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszi_Roka.Classes
{
    public class Methods
    {
        public static void Game()
        {
            AbstractEntity[,] table = FillTable(CreateTable());
            PrintTable(table);
            while (Console.ReadLine() == "next")
            {
                table = Lepes(table);
                PrintTable(table);
            }
        }
        public static AbstractEntity[,] CreateTable()
        {
            const int n = 12;
            AbstractEntity[,] table = new AbstractEntity[n, n];
            return table;
        }
        public static AbstractEntity[,] FillTable(AbstractEntity[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = new Grass();
                }
            }
            Random rnd = new Random();
            int a = table.GetLength(0);
            int b = table.GetLength(1);
            for (int i = 0; i < rnd.Next(2, 5); i++)
            {
                table[rnd.Next(0, a), rnd.Next(0, b)] = new Rabbit();
                table[rnd.Next(0, a), rnd.Next(0, b)] = new Wolf();
            }
            return table;
        }
        public static AbstractEntity[,] Lepes(AbstractEntity[,] table)
        {
            int a = table.GetLength(0);
            int b = table.GetLength(1);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (table[i, j] is Grass)
                    {
                        table[i, j].Fejlodik(1);
                    }
                    if (i != 0 && i != a-1 && j != 0 && j != b-1)
                    {
                        if (table[i, j] is Rabbit)
                        {
                            bool nyuszi_talalt_fuvet = false;
                            for (int k = i - 1; k <= i + 1; k++)
                            {
                                for (int l = j - 1; l <= j + 1; l++)
                                {
                                    if (table[k, l] is Grass && nyuszi_talalt_fuvet == false)
                                    {
                                        int fu_tapertek = int.Parse(table[k, l].ToString().Substring(1, 1));
                                        if (fu_tapertek > 0)
                                        {
                                            table[i, j].Fejlodik(fu_tapertek);
                                            table[k, l] = table[i, j];
                                            table[i, j] = new Grass();
                                            nyuszi_talalt_fuvet = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (table[i, j] is Rabbit || table[i, j] is Wolf)
                    {
                        table[i, j].Csokken(1);
                        table[i, j].Elpusztul();
                    }
                    if (i != 0 && i != a-1 && j != 0 && j != b-1)
                    {
                        if (table[i,j] is Rabbit)
                        {
                            if (table[i - 1, j] is Rabbit)
                            {
                                if (table[i, j - 1] is Grass) table[i, j - 1] = new Rabbit();
                            }
                            if (table[i + 1, j] is Rabbit)
                            {
                                if (table[i, j - 1] is Grass) table[i, j - 1] = new Rabbit();
                            }
                            if (table[i, j + 1] is Rabbit)
                            {
                                if (table[i - 1, j] is Grass) table[i - 1, j] = new Rabbit();
                            }
                            if (table[i, j - 1] is Rabbit)
                            {
                                if (table[i - 1, j] is Grass) table[i - 1, j] = new Rabbit();
                            }

                        }
                    }
                    if (i != 0 && i != a - 1 && j != 0 && j != b - 1)
                    {
                        if (table[i, j] is Wolf)
                        {
                            bool roka_talalt_nyuszit = false;
                            for (int k = i - 1; k <= i + 1; k++)
                            {
                                for (int l = j - 1; l <= j + 1; l++)
                                {
                                    if (table[k, l] is Rabbit && roka_talalt_nyuszit == false)
                                    {
                                        table[i, j].Fejlodik(3);
                                        table[k, l] = table[i, j];
                                        table[i, j] = new Grass();
                                        roka_talalt_nyuszit = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return table;
        }
        public static void PrintTable(AbstractEntity[,] table)
        {
            Console.WriteLine("  A   B   C   D   E   F   G   H   I   J   K   L");
            Console.WriteLine(" --- --- --- --- --- --- --- --- --- --- --- ---");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(table[i, j] + " ");
                }
                Console.Write("|   " + (i + 1));
                Console.WriteLine("");
                Console.WriteLine(" --- --- --- --- --- --- --- --- --- --- --- ---");
            }
        }
    }
}
