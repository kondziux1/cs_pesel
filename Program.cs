namespace cs_pesel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
