using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RoomsToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            // Upon clicking the Rooms tabs, create an instance of Roomform called roomForm and pops up new window as modal dialog box
            RoomForm roomForm = new RoomForm();
            roomForm.ShowDialog();
        }
    }
}
