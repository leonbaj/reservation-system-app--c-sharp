using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemApp.Model
{
/*
  Class for rooms (creates it as an entity)
 */


    public class Room
    {
        // getters and setters for ID, Name, and Price
        public int Id { get; set; } 
        public string Name { get; set; }

        public double Price { get; set; }

        public bool isActive { get; set; }

    }
}
