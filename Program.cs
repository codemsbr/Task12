namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Gallery gallery = new Gallery();
            int userAnswer = 0;
            while (userAnswer != 5) 
            {
                controller.Menu();
                userAnswer = Convert.ToInt32(Console.ReadLine());
                switch (userAnswer)
                {
                    case 1:
                        controller.AddCars(gallery);
                        break;
                    case 2:
                        controller.GetCar(gallery);
                        break;
                    case 3:
                        controller.Upload(gallery);
                        break;
                    case 4:
                        controller.SearchCar(gallery);
                        break;
                    default:
                        Console.WriteLine("Yanlis Secim");
                        break;
                }
            }
        }
    }
}