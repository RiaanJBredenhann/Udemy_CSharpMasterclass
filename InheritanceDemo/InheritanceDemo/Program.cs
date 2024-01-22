namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(true, "Panasonic");
            TV tv = new TV(false, "Samsung");

            radio.ListenToRadio();
            radio.SwitchOff();
            radio.ListenToRadio();
            radio.SwitchOn();
            radio.ListenToRadio();

            tv.WatchTV();
            tv.SwitchOn();
            tv.WatchTV();
            tv.SwitchOff();
            tv.WatchTV();
        }
    }
}
