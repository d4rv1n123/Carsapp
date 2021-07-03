using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.App.API.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
    }
}
