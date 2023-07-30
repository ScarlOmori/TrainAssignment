namespace TrainAssignmentLibrary
{
    /// <summary>
    /// Поезд.
    /// </summary>
    public class Train
    {
        /// <summary>
        /// Указатель на первый вагон поезда.
        /// </summary>
        public Wagon FirstWagon;

        /// <summary>
        /// Указатель на текущий вагон.
        /// </summary>
        public Wagon CurrentWagon;

        Random rnd = new Random();

        /// <summary>
        /// Создаем замкнутый круг из вагонов.
        /// </summary>
        /// <param name="wagonCount">Количество вагонов.</param>
        /// <exception cref="ArgumentOutOfRangeException">Количество вагонов 0 или меньше.</exception>
        public Train(int wagonCount)
        {
            if (wagonCount <= 0)
            {
                throw new ArgumentOutOfRangeException("Количество вагонов должно быть больше 0.");
            }

            FirstWagon = new Wagon();
            CurrentWagon = FirstWagon;

            for (int i = 1; i < wagonCount; i++)
            {
                var newWagon = new Wagon();

                _ = rnd.Next(0, 2) == 0
                    ?
                    newWagon.IsLightOn = true
                    :
                    newWagon.IsLightOn = false;

                newWagon.Number = i;
                CurrentWagon.NextWagon = newWagon;
                CurrentWagon = newWagon;
            }

            CurrentWagon.NextWagon = FirstWagon;
        }

        /// <summary>
        /// Выводит в консоль состояние света (вкл\выкл).
        /// </summary>
        public void PrintLightState()
        {
            if (CurrentWagon == null)
            {
                return;
            }

            Console.WriteLine("Свет включен? " + CurrentWagon.IsLightOn);
        }

        /// <summary>
        /// Возвращает количество вагонов.
        /// </summary>
        /// <returns>Количество вагонов у поезда.</returns>
        public int CountWagons()
        {
            if (FirstWagon == null)
            {
                return 0;
            }

            var count = 1;
            var current = FirstWagon.NextWagon;

            while (current != FirstWagon)
            {
                count++;
                current = current.NextWagon;
            }

            return count;
        }

        /// <summary>
        /// Возвращает номер текущего вагона.
        /// </summary>
        /// <returns>Номер текущего вагона.</returns>
        public int GetCurrentWagonNumber()
        {
            if (CurrentWagon == null)
            {
                return -1;
            }

            return CurrentWagon.Number;
        }

        /// <summary>
        /// Передвигает указатель на следующий вагон.
        /// </summary>
        public void MoveObserver()
        {
            if (CurrentWagon != null)
            {
                CurrentWagon = CurrentWagon.NextWagon;
            }
        }

        /// <summary>
        /// Включаем/выключаем свет в текущем вагоне.
        /// </summary>
        public void ToggleLight()
        {
            if (CurrentWagon != null)
            {
                CurrentWagon.IsLightOn = !CurrentWagon.IsLightOn;
            }
        }
    }
}
