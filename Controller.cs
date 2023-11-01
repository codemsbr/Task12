using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Controller
    {
        public void Menu()
        {
            Console.WriteLine("1.Enter Car");
            Console.WriteLine("2.Getting Array Index Information");
            Console.WriteLine("3.Setting Array Index Information");
            Console.WriteLine("4.Car Name Search");
            Console.WriteLine("5.Exit");
            Console.Write("User Answer : ");
        }

        public void AddCars(Gallery gallery)
        {
            Console.Write("Enter Car Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Colour : ");
            string colour = Console.ReadLine();
            Console.Write("Enter Produced Year : ");
            int producedYear = Convert.ToInt32(Console.ReadLine());
            Cars car = new Cars(name, colour, producedYear);
            gallery.CarAdd(car);
        }
        public void GetCar(Gallery gallery)
        {
            Console.Write("Enter Index : ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (Gallery.GetmyArray.Length > index && index > -1)
            {
                Console.WriteLine(gallery[index]);
            }
        }

        public void Upload(Gallery gallery)
        {
            Console.Write("Enter Index : ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (Gallery.GetmyArray.Length > index && index > -1)
            {
                Console.Write("Enter Car Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Colour : ");
                string colour = Console.ReadLine();
                Console.Write("Enter Produced Year : ");
                int producedYear = Convert.ToInt32(Console.ReadLine());
                gallery[index] = new Cars(name, colour, producedYear);
            }
        }

        public void SearchCar(Gallery gallery)
        {
            Console.Write("Enter Car Name : ");
            string name = Console.ReadLine();
            Console.WriteLine(gallery[name]);
        }
    }
}
