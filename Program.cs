namespace cs_pesel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pesel = new int[10];
            Console.WriteLine("Hello, World!");
            if (args.Length == 0)
            {
                Console.WriteLine("NO INPUT! RUNNING DRY!");
                pesel = new int[] { 5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 0 }; // 11, F, POPRAWNY
            }
            else
            {
                string cut = args[0];
                pesel = cut.Select(c => c - '0').ToArray();//gpt shit
            }
            Console.WriteLine("KamilKadze.gov.pl Pesel Software starting!");
            //RUN
            char kebab = getGender(pesel);
            bool hotdog = checkParrity(pesel);

            Console.WriteLine("Płec kolegi to: " + kebab);

            if (hotdog)
            {
                Console.WriteLine("Pesel kolegi jest poprawny");
            }
            else
            {
                Console.WriteLine("Pesel kolegi jest BŁĘDNY (właśnie jadą po ciebie aby wywieźć cię na ukraine)");
            }

            Console.WriteLine("Dziękujemy za używanie KamilKadze.gov.pl Pesel Software!!!");
        }
        static char getGender(int[] elvdigit)
        {
            if (elvdigit[10] % 2 == 0)
            {
                return 'F';
            }
            else
            {
                return 'M';
            }
        }
        static bool checkParrity(int[] elvdigit)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 }; //10
            int[] corrector = new int[9];
            int S = 0, M = 0, R = 0;

            int check = elvdigit[10];
            //dohickey set a corrector with iloczyn
            for (int i = 0; i < 9; i++)
            {
                corrector[i] = weights[i] * elvdigit[i];
            }
            //sumuj
            for (int i = 0; i < 9; i++)
            {
                S += corrector[i];
            }
            //modulo
            M = S % 10;
            //dohiki
            if (M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }
            //final check
            if (R == check)
            {

                return true;
            }

            return false;
        }
    }
}
