namespace Owo_mi_da
{
    public class Program
    {

        public int rate(int x)
        {
            int output;
            switch (x)
            {
                case 1: 
                    output = 500;
                    break;
                case 2:
                    output = 300;
                    break;
                case 3:
                    output = 200;
                    break;

                default:
                    output = 100;
                    break;
            }
        return output;  



        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {


                Console.WriteLine("Welcome to Owo Mi Da");
                Console.WriteLine("Are you a registered member? (Type 'yes or no')");
                string status = Console.ReadLine();
                string statuss = status.ToLower();
                Console.WriteLine("Vehicle type? (1) Bus (2) Korope (3) Keke (4) Motorcycle");
                int vehicle = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of trips: ");
                int num = Int32.Parse(Console.ReadLine());
                var prog = new Program();
                int amt = prog.rate(vehicle);
                if (statuss == "yes")
                {
                    Console.WriteLine("Your bill is " + num * (amt * 0.7f));
                }
                else
                {
                    Console.WriteLine("Your bill is " + num * (amt));
                }
            }
            
        }
    }
}