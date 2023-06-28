using ReservationSystemApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemApp
{
    public partial class RoomForm : Form

    {

        RoomReservationContent content = new RoomReservationContent(); // populates new content upon load of program 
        public RoomForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double price; //instance variable used in the if statement below 


            /*if statement checks both Price Text box and Name text box to not be null or empty and also checks that the price text box is converted to be a double 
            through use of tryparse which takes in a parameter of string (text from text box) and returns as our instance variable "price" */

            if (!string.IsNullOrEmpty(priceTxtBox.Text) && !string.IsNullOrEmpty(textAddName.Text) && double.TryParse(priceTxtBox.Text, out price))
            {
                content.Rooms.Add(new Room { Name = textAddName.Text, Price = price, isActive = true }); //object room adds listing of new room through given parameters.
                content.SaveChanges(); // saves changes of current entry.
                dataGridView1.DataSource = content.Rooms.ToList(); //load data grid after button has been pushed as well

            }

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = content.Rooms.ToList(); // upon loading RoomForm populates content's Rooms, to the Data Grid on application. 
        }

        //update button does everything as how the add button works. 
        private void updateButton_Click(object sender, EventArgs e)
        {
            double price;
            if(!string.IsNullOrEmpty(IdTextBox.Text) &&!string.IsNullOrEmpty(upNameTxtBox.Text) && !string.IsNullOrEmpty(updatePriceTxtBox.Text) && double.TryParse(updatePriceTxtBox.Text, out price)) 
            {
                //pulls up room from ID an assigns it to var in order to overite data on the room and update it.
                var room = content.Rooms.Find(int.Parse(IdTextBox.Text));
                room.Name = upNameTxtBox.Text;
                room.Price = price;
                room.isActive = checkActive.Checked;
                content.SaveChanges();
                dataGridView1.DataSource = content.Rooms.ToList(); 
            
            }
        }
    }
}
