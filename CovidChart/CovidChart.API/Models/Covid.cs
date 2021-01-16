using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChart.API.Models
{
    public enum ECity
    {
        Istanbul = 1,
        Yalova = 2,
        Ankara = 3,
        Kocaeli = 4,
        Izmir = 5
    }
    public class Covid
    {
        public int Id { get; set; }
        public ECity City { get; set; }
        public int Count { get; set; }
        public DateTime CovidDate { get; set; }
    }
}
