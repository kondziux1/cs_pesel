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
    }
}
