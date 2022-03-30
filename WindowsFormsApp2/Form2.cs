using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2 ()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void btnInsert_Click ( object sender, EventArgs e )
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDo;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";

            int i;

            sql = "Select * from ToDo";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                // columnID.Text = i;
                columnName.Text = dataReader["name"].ToString();
                columnTime.Text = dataReader["deadline"].ToString();
                columnDesc.Text = dataReader["description"].ToString();
                columnUrl.Text = dataReader["link"].ToString();
                columnComm.Text = dataReader["comnentar"].ToString();
                i = Convert.ToInt32(String.Format("{0}", dataReader["id"]));
                //cbb_Prio.SelectedIndex = i;
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
