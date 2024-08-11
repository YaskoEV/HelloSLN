namespace Events
{
    public class Program
    {
        static void Fire(object sender)
        {
            Console.WriteLine("Пожар");
        }
        static void Main(string[] args)
        {
            Switcher switcher = new Switcher();
            Lamp lamp = new Lamp(); 
            TvSet tv = new TvSet();

            //subscribe events
            //switcher.ElectricityOn += new Electricity(lamp.LightOn); //старый способ подписки
            switcher.ElectricityOn += lamp.LightOn;
            switcher.ElectricityOn += tv.TvOn;//новый способ подприски

            //switcher.ElectricityOn -= lamp.LightOn;

            switcher.ElectricityOn += Fire;

            switcher.ElectricityOn += delegate (object sender)
            {
                Console.WriteLine("Всё сгорело");
            };

            //lamda
            switcher.ElectricityOn += sender => Console.WriteLine("Пожарные приехали");
            

            switcher.SwitchOn();
        }
    }
}
 