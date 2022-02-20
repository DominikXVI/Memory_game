var inp = "0";
while ((inp.ToUpper() != "EASY") || (inp.ToUpper() != "HARD"))
{
    Console.WriteLine("Select the game level (Easy/Hard)?");
    string inputN = Console.ReadLine();
    if (inputN.ToUpper() == "EASY")
    {
        var qestY = 1;
        while (qestY == 1)
        {
            string path1 = @"C:\Users\Dominik XVI\Desktop\Osobiste\Rekrutacje\Motorola 02.2022\Zadanie\Words.txt";
            var lineCount = 0;
            using (var reader = File.OpenText(path1))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Random r = new Random();
            var ln1 = r.Next(lineCount + 1);
            var ln2 = r.Next(lineCount + 1);
            var ln3 = r.Next(lineCount + 1);
            var ln4 = r.Next(lineCount + 1);
            string word1 = File.ReadLines(path1).ElementAt(ln1);
            string word2 = File.ReadLines(path1).ElementAt(ln2);
            string word3 = File.ReadLines(path1).ElementAt(ln3);
            string word4 = File.ReadLines(path1).ElementAt(ln4);

            List<string> lines = new List<string>()
            {
                word1, word2, word3, word4, word1, word2, word3, word4
            };

            var randN1 = r.Next(lines.Count);
            var randN2 = randN1;
            while (randN1 == randN2)
            {
                randN2 = r.Next(lines.Count);
            }
            var randN3 = randN1;
            while (randN3 == randN1 || randN3 == randN2)
            {
                randN3 = r.Next(lines.Count);
            }
            var randN4 = randN1;
            while (randN4 == randN1 || randN4 == randN2 || randN4 == randN3)
            {
                randN4 = r.Next(lines.Count);
            }
            var randN5 = randN1;
            while (randN5 == randN1 || randN5 == randN2 || randN5 == randN3 || randN5 == randN4)
            {
                randN5 = r.Next(lines.Count);
            }
            var randN6 = randN1;
            while (randN6 == randN1 || randN6 == randN2 || randN6 == randN3 || randN6 == randN4 || randN6 == randN5)
            {
                randN6 = r.Next(lines.Count);
            }
            var randN7 = randN1;
            while (randN7 == randN1 || randN7 == randN2 || randN7 == randN3 || randN7 == randN4 || randN7 == randN5 || randN7 == randN6)
            {
                randN7 = r.Next(lines.Count);
            }
            var randN8 = randN1;
            while (randN8 == randN1 || randN8 == randN2 || randN8 == randN3 || randN8 == randN4 || randN8 == randN5 || randN8 == randN6 || randN8 == randN7)
            {
                randN8 = r.Next(lines.Count);
            }

            string BGA1 = lines.ElementAt(randN1);
            string BGA2 = lines.ElementAt(randN2);
            string BGA3 = lines.ElementAt(randN3);
            string BGA4 = lines.ElementAt(randN4);
            string BGB1 = lines.ElementAt(randN5);
            string BGB2 = lines.ElementAt(randN6);
            string BGB3 = lines.ElementAt(randN7);
            string BGB4 = lines.ElementAt(randN8);

            List<string> wordsbg = new List<string>()
            {
                BGA1, BGA2, BGA3, BGA4, BGB1, BGB2, BGB3, BGB4
            };

            var A1 = "X";
            var B1 = "X";
            var A2 = "X";
            var B2 = "X";
            var A3 = "X";
            var B3 = "X";
            var A4 = "X";
            var B4 = "X";

            Console.WriteLine("Easy");
            Console.WriteLine("Rounds remaining: {0}", "10");
            Console.WriteLine("{0}    {1, -20} {2,5}\n", " ", "A", "B");
            Console.WriteLine("{0}    {1, -20} {2,5:N1}", "1", A1, B1);
            Console.WriteLine("{0}    {1, -20} {2,5:N1}", "2", A2, B2);
            Console.WriteLine("{0}    {1, -20} {2,5:N1}", "3", A3, B3);
            Console.WriteLine("{0}    {1, -20} {2,5:N1}", "4", A4, B4);
            Console.WriteLine();

            int i = 0;
            for (i = 10; i > -0.5; i--)
            {
                string first = "a";
                string second = "b";
                Console.WriteLine("Enter the first coordinates: ");
                string inputfirst = Console.ReadLine();
                Console.WriteLine("Enter the second coordinates: ");
                string inputsecond = Console.ReadLine();
                Console.WriteLine();

                if (inputfirst.ToUpper() == "A1")
                {
                    A1 = wordsbg.ElementAt(0);
                    first = A1;
                }
                else if (inputfirst.ToUpper() == "A2")
                {
                    A2 = wordsbg.ElementAt(1);
                    first = A2;
                }
                else if (inputfirst.ToUpper() == "A3")
                {
                    A3 = wordsbg.ElementAt(2);
                    first = A3;
                }
                else if (inputfirst.ToUpper() == "A4")
                {
                    A4 = wordsbg.ElementAt(3);
                    first = A4;
                }
                else if (inputfirst.ToUpper() == "B1")
                {
                    B1 = wordsbg.ElementAt(4);
                    first = B1;
                }
                else if (inputfirst.ToUpper() == "B2")
                {
                    B2 = wordsbg.ElementAt(5);
                    first = B2;
                }
                else if (inputfirst.ToUpper() == "B3")
                {
                    B3 = wordsbg.ElementAt(6);
                    first = B3;
                }
                else if (inputfirst.ToUpper() == "B4")
                {
                    B4 = wordsbg.ElementAt(7);
                    first = B4;
                }

                if (inputsecond.ToUpper() == "A1")
                {
                    A1 = wordsbg.ElementAt(0);
                    second = A1;
                }
                else if (inputsecond.ToUpper() == "A2")
                {
                    A2 = wordsbg.ElementAt(1);
                    second = A2;
                }
                else if (inputsecond.ToUpper() == "A3")
                {
                    A3 = wordsbg.ElementAt(2);
                    second = A3;
                }
                else if (inputsecond.ToUpper() == "A4")
                {
                    A4 = wordsbg.ElementAt(3);
                    second = A4;
                }
                if (inputsecond.ToUpper() == "B1")
                {
                    B1 = wordsbg.ElementAt(4);
                    second = B1;
                }
                else if (inputsecond.ToUpper() == "B2")
                {
                    B2 = wordsbg.ElementAt(5);
                    second = B2;
                }
                else if (inputsecond.ToUpper() == "B3")
                {
                    B3 = wordsbg.ElementAt(6);
                    second = B3;
                }
                else if (inputsecond.ToUpper() == "B4")
                {
                    B4 = wordsbg.ElementAt(7);
                    second = B4;
                }
                string[] coordinatesA = { A1, A2, A3, A4 };
                string[] coordinatesB = { B1, B2, B3, B4 };
                string[] coordinatesNr = { "1", "2", "3", "4" };
                Console.WriteLine("Easy");
                Console.WriteLine("Rounds remaining: {0}", i - 1);
                Console.WriteLine("{0}    {1, -20} {2,5}\n", " ", "A", "B");
                for (int ctr = 0; ctr < coordinatesA.Length; ctr++)
                    Console.WriteLine("{0}    {1, -20} {2,5:N1}", coordinatesNr[ctr], coordinatesA[ctr], coordinatesB[ctr]);
                Console.WriteLine();
                if (A1 != "X" && A2 != "X" && A3 != "X" && A4 != "X" && B1 != "X" && B2 != "X" && B3 != "X" && B4 != "X")
                {
                    break;
                }
            }
            if (i == -1)
            {
                Console.WriteLine("Game over! Do you want to play again? [Y/N]");
                string inputquest = Console.ReadLine();
                if (inputquest.ToUpper() == "Y")
                {
                    qestY = 1;
                }
                else
                {
                    break;
                }
            }
            else
            {
                i = 11 - i;
                Console.WriteLine("Great! You only needed {0} roud", i);
                Console.WriteLine("Do you want to play again? [Y/N]");
                string inputquest = Console.ReadLine();
                if (inputquest.ToUpper() == "Y")
                {
                    qestY = 1;
                }
                else
                {
                    break;
                }
            }
        }
        break;
    }
    else if (inputN.ToUpper() == "HARD")
    {
        Console.WriteLine("In development");
        break;
    }
}
