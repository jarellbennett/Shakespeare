using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace shakyspear
{
    class Program
    {
        static void Main(string[] args)
        {

            
            FileStream philly = File.OpenRead(@"C:\Users\WeCanCodeIT\Documents\visual studio 2015\Projects\shakyspear\shakyspear\Shakespeare.txt");
            int interest = 1;
            int pick;
            while(interest ==1)
            {
                StringBuilder huuh = new StringBuilder();

                huuh.Append('\n' + "Stream Reader Assignment");
                huuh.Append('\n' + "1.First task");
                huuh.Append(" 2.Second Task");
                huuh.Append(" 3.Third Task");

                Console.WriteLine(huuh.ToString());
                pick = int.Parse(Console.ReadLine());
                switch(pick)
                {
                    case 1:
                        oneHit(philly);
                        break;

                    case 2:
                        steak(philly);
                        break;

                    case 3:
                        speci();
                        break;
                }
                Console.WriteLine("Would you like to continue? Enter 1 for yes");
                interest = int.Parse(Console.ReadLine());
                
            }


        }

        static void oneHit(FileStream bob)
        {
            StreamReader tom = new StreamReader(bob);
            int lineNum = 0;

            string line = tom.ReadLine();
            using (tom)
            {
                while (lineNum <= 1)
                {
                    lineNum++;
                    Console.WriteLine("Line {0}: {1}", lineNum, line);
                    line = tom.ReadLine();

                }

                
            }
        }

        static void steak(FileStream bobo)
        {
            StreamReader tom = new StreamReader(bobo);
            int lineNum = 0;

            string line = tom.ReadLine();
            using (tom)
            {
                while (line != null)
                {
                    lineNum++;
                    Console.WriteLine("Line {0}: {1}", lineNum, line);
                    line = tom.ReadLine();

                }
            }
            

        }

        static void speci()
        {
            

            StringBuilder newFile = new StringBuilder();

            string temp = "";

            string[] file = File.ReadAllLines(@"C:\Users\WeCanCodeIT\Documents\visual studio 2015\Projects\shakyspear\shakyspear\Shakespeare.txt");

            foreach (string line in file)

            {

                if (line.Contains("a"))

                {

                    temp = line.Replace("a", "A");

                    newFile.Append(temp + "\r\n");

                    continue;

                }

                newFile.Append(line + "\r\n");

            }

            File.WriteAllText(@"C:\Users\WeCanCodeIT\Documents\visual studio 2015\Projects\shakyspear\shakyspear\NewShakespeare.txt", newFile.ToString());
        }



    }
}
