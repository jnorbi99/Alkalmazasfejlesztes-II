using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    public static class Tasks
    {
        public static void StartTasks(string[] args)
        {
            //Jelenlegi elérési útvonal lekérése
            string _currentPath = Environment.CurrentDirectory;
            string _charactersFilePath = "";
            string _sentencesFilePath = "";

            //Csak 2 argumentum esetén fut le a program
            if (args.Length == 2)
            {
                _charactersFilePath = args[0];
                _sentencesFilePath = args[1];
            } else
            {
                return; 
            }
            
            /* 1.Feladat:
             * Készítsd el a CSV-kben található adattípusoknak megfelelő osztályt
             * (popertyk használatával).
             * 
             * Character.cs & Sentences.cs file
             */

            //Kollekciók létrehozása
            List<Character> characters = new();
            List<Sentences> sentences = new();

            /* 2.Feladat:
             * Olvasd be a fájlokat, tárold el egy tetszőleges kollekcióban
             * a tartalmukat.
             */

            //Karakterek beolvasása a Characters.csv fájlból
            using (var reader = new StreamReader(_charactersFilePath))
            {
                while (!reader.EndOfStream)
                {
                    //Soronkénti beolvasás
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    //Ha a csv első sora, akkor tovább lépek a következő sorra
                    if (values[0] == "Id")
                    {
                        continue;
                    }

                    //Létrehozok egy új karaktert
                    Character c = new();

                    //A karakter adattagjait beállítom, ha jó a sor
                    try
                    {
                        c.ID = Int32.Parse(values[0]);
                        c.Name = values[1].ToUpper();
                        c.Gender = values[2];
                        c.Job = values[3];
                        c.House = values[4];
                        c.Wand = values[5];
                        c.Patronus = values[6];
                        c.Species = values[7];
                        c.BloodStatus = values[8];
                        c.HairColour = values[9];
                        c.EyeColour = values[10];
                        c.Loyality = values[11];
                        c.Skills = values[12];
                        c.Birth = values[13];
                        c.Death = values[14];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Something wrong in Characters");
                    }
                    //A karaktert hozzáadoma listámhoz
                    characters.Add(c);
                };
            }

            //A szöveg beolvasása a Harry-Potter-3.csv fájlból
            using (var reader = new StreamReader(_sentencesFilePath))
            {
                //Amíg nincs vége a fájlnak, addíg fut a while ciklus
                while (!reader.EndOfStream)
                {
                    //Beolvasott sorok és elemek létrehozása
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (values[0] == "CHARACTER" || values[0] == null)
                    {
                        continue;
                    }

                    //Új Sentences létrehozása
                    Sentences s = new();

                    //értékadás, a jó sorok esetén
                    try
                    {
                        s.Name = values[0];
                        s.Sentence = values[1];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Something wrong in Sentences at ");
                    }

                    //Kollekcióhoz adás
                    sentences.Add(s);
                }
            }

            /* 3.Feladat:
             * Készíts egy harmadik kollekciót, ami összefésüli az adatokat a két 
             * CSVből és a következő adatokat tartalmazza: name, house, patronus, 
             * [összes mondatja a karakternek], név szerint rendezve Z-A-ig.
             */

            var subsetHelp = from b in characters
                             orderby b.Name descending
                             select b;
;
            string allSenString = "";

            using var writer3 = new StreamWriter(_currentPath + @"\task3.csv");

            foreach (var v in subsetHelp)
            {
                var sen = from b in sentences
                          where v.Name.Contains(b.Name)
                          select b.Sentence;

                foreach(var v2 in sen)
                {
                    allSenString += v2 + "; ";
                }

                writer3.WriteLine(v.Name + " _ " + v.House + " _ " + v.Patronus + " _ " + allSenString);
                allSenString = "";

            }
            writer3.Close();

            /* 4.Feladat:
             * A kapott adatok alapján számold meg különböző “vérekhez” tartozó a
             * hallgatókat.
             */

            var blood = from c in characters
                        where c.Job == "Student"
                        select c.BloodStatus;

            var subset = from b in blood
                          group b by b into g
                          select new { Name = g.Key, Duplicatecount = g.Count() };

            using var writer4 = new StreamWriter(_currentPath + @"\task4.csv", append: false);

            foreach(var v in subset)
            {
                if(v.Name != "")
                {
                    writer4.WriteLine(v.Name + ": " + v.Duplicatecount);
                }  
            }

            /* 5.Feladat:
             * Keresd ki, hogy melyik háznak van a legtöbb hallgatója…
             */

            var houses = from c in characters
                         where c.Job == "Student"
                         select c.House;

            using var writer5 = new StreamWriter(_currentPath + @"\task5.csv");

            var subset2 = from hous in houses
                    group hous by hous into g
                    select new { Name = g.Key, Duplicatecount = g.Count() };

            
            var mxHouse = from s in subset2
                          orderby s.Duplicatecount descending
                          select s;

            writer5.WriteLine(mxHouse.First().Name);

            /* 6.Feladat:
             * Keresd ki, hogy melyik háznak van a legkevesebb hallgatója…
             */

            using var writer6 = new StreamWriter(_currentPath + @"\task6.csv");

            writer6.WriteLine(mxHouse.Last().Name);

            /* 7.Feladat:
             * Listázd ki azokat a karaktereket, akiknek legalább 10 mondatja van 
             * (név, mondatszám), mondatszám szerint rendezve.
             */

            using var reader2 = new StreamReader(_currentPath + @"\task3.csv");

            List<string> allSentence = new();
            while(!reader2.EndOfStream)
            {
                allSentence.Add(reader2.ReadLine());
            }

            var senNums = from r in allSentence
                          where r.Split(" _ ")[3].Split("; ").Length >= 10
                          orderby r.Split(" _ ")[3].Split("; ").Length descending
                          select r;

            using (var writer = new StreamWriter(_currentPath + @"\task7.csv"))
            {
                foreach (var r in senNums)
                {
                    writer.WriteLine(r.Split(" _ ")[0] + ": " + (r.Split(" _ ")[3].Split("; ").Length - 1));
                }
            }

            /* 8.Feladat:
             * Számold ki a nemek arányát házanként.
             */

            var houses2 = from c in characters
                          where c.Name != null
                          select c.House;

            List<string> houseList2 = new();

            foreach(string s in houses2)
            {
                if(!houseList2.Contains(s))
                {
                    houseList2.Add(s);
                }
            }

            using var writer8 = new StreamWriter(_currentPath + @"\task8.csv", append: false);

            foreach (string s in houseList2)
            {
                if (s != "")
                {
                    var subset4Male = from c in characters
                                       where c.House == s && c.Gender == "Male"
                                       select c;

                    var subset4emale = from c in characters
                                        where c.House == s && c.Gender == "Female"
                                        select c;
                    writer8.WriteLine(s + ": " + "Male: " + subset4Male.Count() + " Female: " + subset4emale.Count());  
                }
            }

            /* 9.Feladat:
             * Listázd ki azokat a karaktereket, akik nem hallgatók.
             */

            var subset4 = from c in characters
                          where c.Job != "Student"
                          select c.Name;

            using (var writer = new StreamWriter(_currentPath + @"\task9.csv"))
            {
                writer.WriteLine(subset4.Count());
            }

            /* 10.Feladat:
             * Minden feladat megoldását írd ki egy taskX CSV fájlba, 
             * ahol X a megfelelő feladat sorszáma. Pl. a 3. feladat 
             * megoldása a task3.csv fájlba kell kerüljön.
             */
        }
    }
}

