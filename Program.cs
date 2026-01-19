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
                List.Add(d);
            }
        }
        }

    }

