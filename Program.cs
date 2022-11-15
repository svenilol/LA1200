
int Unit = 0;


    Console.WriteLine("Guten Tag.");
    Console.WriteLine("Welche Schwierigkeit wollen sie wählen?");
    Console.WriteLine("Schwer = 1, Mittel = 2, Leicht = 3 ");

    string A = Console.ReadLine();
    int i = Convert.ToInt32(A);

    switch (i)
    {
        case int n when (n == 1):
            Console.WriteLine("Sie haben die Schwere Wörterschwirigkeit gewählt");
            break;
        case int n when (n == 2):
            Console.WriteLine("Sie haben die Mittlere Wörterschwirigkeit gewählt");
            break;
        case int n when (n == 3):
            Console.WriteLine("Sie haben die Einfache Wörterschwirigkeit gewählt");
            break;
        default:
            Console.WriteLine("Fehler!");
            break;

    }

    Console.WriteLine("Welche Unit Wollen Sie Abfragen?");


    if (Unit == 1)
    {
        // öfnen der Unit 1 Wörterliste
    }

    Console.WriteLine("Wie sollen die Wörter abgefragt werden? (De zu En) = 1 Oder (En zu De) = 2.");

    int language = Convert.ToInt32(Console.ReadLine);

    if (language == 1)
    {
        //De zu En
    }

    if (language == 2)
    {
        // En zu De
    }











            Console.WriteLine();
            int Falsch = 0;
            int index = 0;
            int Durchschnitt = 0;
            bool r = false;
            string[] Antwort = new string[19];
            var item = new List<string>();
            var data = new List<List<string>>();
            string file = "e.txt";
            data = ReadFromFile(file);
            string Deutsch = "d.txt";
            string[] DeutscheWörter = File.ReadAllLines(Deutsch);
            Console.WriteLine(DeutscheWörter[1]);


            string[][] EnglischWörter = data.Select(a => a.ToArray()).ToArray();

            for (int Zahl = 0; Zahl == 20; Zahl++)
            {
                var rnd = new Random();
                index = rnd.Next(0, 20);

                Console.WriteLine();


                for (int j = 0; j < EnglischWörter[index].Length; j++)
                {
                    Console.WriteLine();
                    Antwort[Zahl] = Console.ReadLine();
                    if (Antwort[Zahl] == EnglischWörter[index][j])
                    {
                        r = true;
                    }
                    if (r == false)
                    {
                        Falsch++;
                    }
                }



            }

            Durchschnitt = Falsch / 20;
            Durchschnitt *= 100;


        static List<List<string>> ReadFromFile(string filename)
        {
            var fileItem = new List<string>();
            var fileData = new List<List<string>>();
            using (var sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fileItem = line.Split('\t').ToList();
                    fileData.Add(fileItem);
                }
                return fileData;
            }



        }