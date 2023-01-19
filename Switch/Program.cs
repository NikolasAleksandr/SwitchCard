namespace SwitchCard
{
    internal class Program
    {
        public static object CardLibrary { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Kaardi loosimine");

            int result = new Random().Next(1,4);

            switch (result)
            {
                case 1:
                    Console.WriteLine("Said poti♠, must kaardimast");
                    break;
                case 2:
                    Console.WriteLine("Said risti♣, must kaardimast");
                    break;
                case 3:
                    Console.WriteLine("Said ruutu♦, punane kaardimast");
                    break;
                case 4:
                    Console.WriteLine("Said ärtu♥, punane kaardimast");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}