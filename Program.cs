using System.Diagnostics.Tracing;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diak> list = new List<Diak>();
            var sorok = File.ReadAllLines("BMI.txt"
                , System.Text.Encoding.Latin1).Skip(1); ;
            foreach (var sor in sorok)
            {
                Console.WriteLine(sor);
                string[] darabok = sor.Split(';');
                string név = darabok[0];
                int életkor = Convert.ToInt32(darabok[1]);
                int magasság = Convert.ToInt32(darabok[2]);
                int súly = Convert.ToInt32(darabok[3]);
                Diak d = new Diak(név, életkor, magasság, súly);
                list.Add(d);


            }
            Console.Clear();
            foreach (var d in list)
            {
                Console.WriteLine();
                Console.WriteLine(d);
            }
            Console.WriteLine($"3. a, feladat: A diákok száma: {list.Count}");
            Diak legmagasabb = list[0];
            foreach (var d in list)
            {
                if (d.Magasság > legmagasabb.Magasság)
                {
                    legmagasabb = d;
                }
                Console.WriteLine($"3. b, feladat: A legmagasabb diák: {legmagasabb.Név}, {legmagasabb.Magasság} cm");

                foreach (var Diak in list)
                {
                    Console.WriteLine($"{d.Név}: {d.BMI()}");
                }
                double atlag = 0;
                foreach (var Diak in list)
                {
                    atlag += d.Súly;
                }
                atlag/= list.Count;
                Console.WriteLine($"5. d, feladat: A diákok átlagos súlya: {atlag:F1} kg");
            }

            int egeszsegesDb = 0;
            foreach (var d in list)
            {
                if (d.BMI() == "normál")
                {
                    egeszsegesDb++;
                }
            }

            Console.WriteLine($"5. b, feladat: Egészséges BMI-jű diákok száma: {egeszsegesDb}");

            bool vanTothEva = false;

            foreach (var d in list)
            {
                if (d.Név == "Tóth Éva")
                {
                    vanTothEva = true;
                    break;
                }
            }

            Console.WriteLine("----------------");

            if (vanTothEva)
                Console.WriteLine("5. c, feladat: Van Tóth Éva a diákok között");
            else
                Console.WriteLine("5. c, feladat: Nincs Tóth Éva a diákok között");

            Console.ReadKey();
            string fajlba = "Név; BMI/n";
            foreach (var d in list)
            {
               double magasságM = d.Magasság / 100.0;
                double BMI = d.Súly / (magasságM * magasságM);
                fajlba += d.Név + ";" + BMI + "/n";
            }
            File.WriteAllText("egeszseges_diakok.txt", fajlba);
        }
    }
}
        
    


    

