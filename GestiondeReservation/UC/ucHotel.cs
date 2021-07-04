using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestiondeReservation.UC
{
    public partial class ucHotel : UserControl
    {

        public ucHotel()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is ucRoom)
                {
                    ucRoom room = (ucRoom)item;
                    room.ShowStatus(dateTimePicker1.Value);
                }

            }
        }
    }
}
