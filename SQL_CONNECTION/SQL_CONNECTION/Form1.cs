using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_CONNECTION
{
    public partial class Sql_Connect : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-SQ9BA76\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
        public Sql_Connect()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
             
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        btn_connect.Text = "Close";
                        lbl_message.Text = "Connection open!";
                        return;
                    }
                    
                            conn.Close();
                            btn_connect.Text = "Open";
                            lbl_message.Text = "Connection Closed!";
                
           
            
        }

    }
}
