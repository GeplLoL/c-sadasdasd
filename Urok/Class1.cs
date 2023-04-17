using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok
{
    public class Class1
    {
        public static void Main(string[] args)
        {

            /*try
            {
                StreamWriter text = new StreamWriter(@"..\..\..\TextFile.txt", true);
                text.WriteLine(Console.ReadLine());
                string lause = "Lisa failisse lause\n";
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga");
            }
            try
            {
                StreamReader text = new StreamReader(@"..\..\..\TextFile1.txt");
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine("Failis on järgmine informatsioon: \n");
                Console.WriteLine(laused);
            }
            catch (Exception)
            {

                throw;
            }
            List<string> list_failist = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\TextFile.txt"))
                {
                    list_failist.Add(rida);
                }
            }
            catch (Exception)
            {
                
            }
            foreach (string rida in list_failist)
            {
                Console.WriteLine(rida);
            }
            //ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            //do
            //{
            //    Console.WriteLine("Vajuta Backspace");
            //    nupp=Console.ReadKey();
            //} while (nupp.Key!=ConsoleKey.Backspace);

            /*Dictionary<int, string> dic = new Dictionary<int, string>(5);
            dic.Add(1, "üks");
            dic.Add(2, "kaks");
            dic[3] = "kolm";
            dic[4] = "neli";
            dic[5] = "viis";
            foreach (KeyValuePair<int,string> keyValue in dic)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }
            List<Inimene> list = new List<Inimene>();
            Inimene inimene = new Inimene();
            inimene.Nimi = "Mati";
            inimene.Vanus = 61;
            list.Add(inimene);
            list.Add(new Inimene() { Nimi="Kati"});
            foreach (Inimene item in list)
            {
                Console.WriteLine(item.Nimi);
            }
            ArrayList arrayList= new ArrayList();
            arrayList.Add("Esimine");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            if (arrayList.Contains("Teine"))
            {

                Console.WriteLine("Sõna Teine on olemas!");
                Console.WriteLine("Teine asub kohal"+arrayList.IndexOf("Teine"));
            }
            else
            {
                Console.WriteLine("Otsitav, sõna, puudub");
            }
            Console.WriteLine("Kokku järjendis on "+arrayList.Count+" elemente");
            arrayList.Insert(3, "Neljapa");
            arrayList.Insert(4, "Viies");
            arrayList.Sort();
            foreach (string item in arrayList)
            {
                Console.Write(item + ", ");
            }
            arrayList.RemoveAt(0);
            arrayList.Remove("Viies");
            arrayList.Clear();
            Dictionary<int, Inimene> stud = new Dictionary<int, Inimene>(3);
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Mati";
            inimene1.Vanus = 65;
            Inimene inimene2 = new Inimene();
            inimene2.Nimi = "Kati";
            inimene2.Vanus = 34;
            stud.Add(1, inimene);
            stud.Add(2, inimene1);
            stud.Add(3, new Inimene() { Nimi = "Marina", Vanus = 100});
            foreach (KeyValuePair<int, Inimene> item in stud)
            {
                Console.WriteLine(item.Key + "-" + item.Value.Nimi);
            }*/
            StreamReader text = new StreamReader(@"..\..\..\Linn.txt");
            string laused = text.ReadToEnd();
            text.Close();

        }
    }
}
