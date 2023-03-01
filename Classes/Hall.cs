using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    public class Hall
    {
        /// <summary>
        /// Id зала в бд
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название зала
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Вместимость зала
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Тип экрана
        /// </summary>
        public string ScreenType { get; set; }
    }
}
