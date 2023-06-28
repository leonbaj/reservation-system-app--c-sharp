using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemApp.Model
{
    // inherits DbContext
    public class RoomReservationContent : DbContext

    {
        public RoomReservationContent() : base("RoomContent") { }
        //sets Rooms, and gets. 
        public DbSet<Room> Rooms { get; set; }

    }
}
