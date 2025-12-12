namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            int valasztott = Kivalasztott(menupontok.Count);
            switch (valasztott)
            {
                case 1:
                    Console.Write("Adja meg a háromszög egyik oldalat: ");
                    int oldal = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adj meg egy számot: ");
                    int magassag_vonal = Convert.ToInt32(Console.ReadLine());
                    Terulet(oldal,magassag_vonal); //cső Makay! Szervus Szabolcs
                    break;
                case 2:Kerulet(); break;

              //  default:
            //    break;
            }
            Console.WriteLine("Vége! Mindennek vége! Mindennek!");
        }

        private static void ListazMenu(List<string> menupontok)
        {
            Console.WriteLine("[1]" + menupontok[0]);
            Console.WriteLine("[2]" + menupontok[1]);
            Console.WriteLine("[3]" + menupontok[2]);
        }

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");

        }
        private static int Kivalasztott(int valasztas)
        {
            Console.WriteLine($"Adjon meg egy számot: ");
            valasztas = Convert.ToInt32(Console.ReadLine());
            return valasztas-1;
        }
        private static void Terulet(int oldal,int magassag_vonal)
        {
            float eredmeny = oldal * magassag_vonal / 2;
            Console.WriteLine($"A háromszög területe: {Math.Round(eredmeny,3)}");
        }
        private static void Kerulet()
        {
            
        }
    }
}
