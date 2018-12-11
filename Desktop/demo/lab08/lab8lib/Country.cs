using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab8lib
{
    public class Country
    {
        public string Name { get; set; }
        public string Towns { get; set; }
        public int Population { get; set; }
        public int Square { get; set; }
        public bool HasSea { get; set; }
        public override string ToString()
        {
            return string.Format("Имя: {0}| Кол-во городов:{1}| Кол-во населения:{2}| Площадь(кв.км.):{3} ({4})", Name, Towns, Population, Square, HasSea ? "Омывается морями" : "Не омывается морями"); ;
        }
    }
   
}
