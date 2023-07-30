namespace TrainAssignmentLibrary
{
    public class Program
    {
        public static void Main()
        {
            var train = new Train(5);

            Console.WriteLine("Изначальное состояние.");
            Console.WriteLine("Количество вагонов в поезде: " + train.CountWagons());
            train.PrintLightState();
            Console.WriteLine("Состояние после передвижения по поезду.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Текущий вагон: " + train.GetCurrentWagonNumber());
                train.ToggleLight();
                train.PrintLightState();
                train.MoveObserver();
            }
        }
    }
}