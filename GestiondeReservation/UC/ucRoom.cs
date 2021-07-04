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
    public partial class ucRoom : UserControl
    {
        String myConnection = "Server=127.0.0.1; Database=gestreservation; Uid=root; Pwd=";
        MySqlConnection cnx;
        
        public int Num { get; set; }

        public void ShowStatus(DateTime dRes)
        {
            cnx = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand("select numChambre, dateRes from reservation", cnx);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            cnx.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int numChambre = reader.GetInt32("numChambre");
                    DateTime dateRes = reader.GetDateTime("dateRes");
                    if (numChambre == this.Num && dRes.Date == dateRes)
                    {
                        this.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        this.BackColor = Color.Yellow;
                    } 
                }
            }
        }

        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            lbNum.Text = Num.ToString();
            
        }

        
    }
}
