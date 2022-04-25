namespace Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); // ohjelma avaa valikon
        }
            
        static void Menu() // Valikko
        {
            Console.Clear(); //näytön puhdistus
            System.Console.WriteLine("Main menu\n"); //valikko tekstin tulostus
            System.Console.WriteLine("1. Information");
            System.Console.WriteLine("2. Calculator");
            System.Console.WriteLine("3. Exit");
            System.Console.WriteLine("Select option by entering the corresponding number");
            
            string select;
            select = System.Console.ReadLine(); // valikko valinta
            switch(select)
            {
                case"1": Nfo(); break;
                case"2": Cal(); break;
                case"3": Exit(); break;
            }
            Menu();
        }
    
        static void Nfo() // info
        {
            Console.Clear();
            System.Console.WriteLine("This is an info page\nReturn to menu by pressing enter"); // info tekstin tulostus
            Console.ReadLine();
        }
        static void Cal() // Laskin
        {
            try
            {
            Console.Clear();
            System.Console.WriteLine("tämä on yhteen laskija\nanna numero"); // ohjelman selitys
            int yksi =Convert.ToInt32(Console.ReadLine()); // numero syöte
            System.Console.WriteLine("anna toinen numero");
            int kaksi =Convert.ToInt32(Console.ReadLine()); // toisen numeron syöte
            int vastaus =laskin(yksi, kaksi); // numeroiden lähetys metodille ja vastauksen haku
            System.Console.WriteLine("vastaus on "+vastaus); // vastauksen tulostus
            
            System.Console.WriteLine("laske uudelleen tai poistu y/n"); // laskimesta poistuminen
            string calx =Console.ReadLine();
            if(calx=="y") Cal();
            else Menu();
            }
            
            catch
            {
            System.Console.WriteLine("error anna numero "); // virheen tarkistus
            System.Threading.Thread.Sleep(2000);Cal();
            }

            static int laskin(int yksi, int kaksi) // laskin metodi
            {
            int vastaus =yksi +kaksi; // yhteenlasku algoritmi
            return vastaus;
            }
        }     
        static void Exit() //sovelluksesta poistuminen
        {
            Console.Clear();
            System.Console.WriteLine("are you sure you want to exit the program?\ntype y or n");
            string evar =Console.ReadLine(); //varmistus
            
            if(evar =="y")
            {
                Console.Clear(); 
                System.Environment.Exit(1);
            }
        
            else{Menu();}        
        }
    }  
}