using abstractclass.Models;

namespace abstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new(4,false,"Mercedes","Çeşka", "silver" ,25 ,50);
           
            Bicycle bicycle = new Bicycle( "tekerli","Sederek" , "kuce velosipedi",  "pink", 7, 15);
            
            car.AverageSpeed();
            bicycle.AverageSpeed();
            car.GetInfo();
            car.DefineNatureHarmness();
            bicycle.GetInfo();
            bicycle.DefineNatureHarmness();


            Vehicle[] vehicles = { car, bicycle};
            foreach (var item in vehicles)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
