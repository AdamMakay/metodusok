namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            String szoveg = "Haromszog";
            Udvozol(szoveg);
            list.Add("Kerulet");
            list.Add("Terulet");
            list.Add("Kilepes");
            Menu(list);
            int kivalasztott_menu = Kivalasztott(list.Count);
            switch (kivalasztott_menu-1)
            {
                
                case 0:
                    Console.Write("Adjon meg egy oldalt: ");
                    int A_oldal = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adjon meg egy oldalt: ");
                    int B_oldal = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adjon meg egy oldalt: ");
                    int C_oldal = Convert.ToInt32(Console.ReadLine());
                    Kerulet(A_oldal,B_oldal,C_oldal);
                    break;
                
                case 1:
                    Console.Write("Adjon meg egy oldalt: ");
                    int oldal = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adja meg az oldalnak a magassag vonalat: ");
                    int oldal_magassagv = Convert.ToInt32(Console.ReadLine());
                    Terulet(oldal,oldal_magassagv);
                    break;
                
                case 2:
                    Console.WriteLine("VEGE");
                    break;
                default:
                    break;
            }
        }
        static void Udvozol(String szoveg)
        {
            int Con_width = Console.WindowWidth;
            Console.SetCursorPosition((Con_width - szoveg.Length) / 2, 0);
            Console.WriteLine(szoveg);
        }

        static void Menu(List<string> lista)
        {
            Console.WriteLine("[1]" + lista[0]);
            Console.WriteLine("[2]" + lista[1]);
            Console.WriteLine("[3]" + lista[2]);
        }
        static int Kivalasztott(int szam)
        {
            int valaszt = Convert.ToInt32(Console.ReadLine());
            return valaszt;
        }
        static void Kerulet(int a, int b, int c)
        {
           Console.WriteLine(a+b+c);
        }
        static void Terulet(int a, int b)
        {
            Console.WriteLine(Convert.ToDouble(a*b/2));
        }

    }
}
