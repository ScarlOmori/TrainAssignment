using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainAssignmentLibrary
{
    /// <summary>
    /// Вагон в поезде.
    /// </summary>
    public class Wagon
    {
        /// <summary>
        /// Включен ли свет в вагоне.
        /// </summary>
        public bool IsLightOn { get; set; }

        /// <summary>
        /// Указатель на следующий вагон.
        /// </summary>
        public Wagon NextWagon { get; set; }

        /// <summary>
        /// Номер вагона.
        /// </summary>
        public int Number { get; set; }
    }
}
