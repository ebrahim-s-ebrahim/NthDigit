namespace PiOrE
{
    internal class Program
    {
        public static readonly double e = Math.E;
        public static readonly double Pi = Math.PI;
        static void Main(string[] args)
        {
            string value;
            string PiE;

            do
            {
                Console.WriteLine("Enter Pi or e: ");
                PiE = Console.ReadLine();

            } while (IsE(PiE) == false && IsPi(PiE) == false);


            do
            {
                Console.WriteLine("Enter the number of digits you want to display (Up to 14)");
                value = Console.ReadLine();

            } while (IsDigits(value) == false);


            if (PiE == "pi")
            {
                if (int.Parse(value) >= 15)
                {
                    Console.WriteLine(Math.Round(Pi, 14));
                }
                else
                {
                    Console.WriteLine(Math.Round(Pi, int.Parse(value)));
                }
            }
            else if (PiE == "e")
            {
                if (int.Parse(value) >= 15)
                {
                    Console.WriteLine(Math.Round(e, 14));
                }
                else
                {
                    Console.WriteLine(Math.Round(e, int.Parse(value)));
                }
            }


        }
        public static bool IsDigits(string value)
        {
            foreach (char c in value)
            {
                {
                    if (c < '0' || c > '9')
                        return false;
                }
            }
            return true;
        }
        public static bool IsPi(string value)
        {
            if (value.ToLower() == "pi")
                return true;
            return false;
        }
        public static bool IsE(string value)
        {
            if (value.ToLower() == "e")
                return true;
            return false;
        }
    }
}