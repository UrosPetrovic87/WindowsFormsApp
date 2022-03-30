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
    public partial class FormUrl : Form
    {
        public FormUrl ()
        {
            InitializeComponent();
        }

        
        

        private void Form1_Load ( object sender, EventArgs e )
        {

           

        }

        private void btnSave_Click ( object sender, EventArgs e )
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDo;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            

            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            string text = textBoxID.Text;
            int i;
            string p;
            string s;

            sql = "Select * from ToDo where ID = " + text;
            command = new SqlCommand(sql, cnn);
            dataReader=command.ExecuteReader();

            while (dataReader.Read())
            {

                textBox1.Text = dataReader["name"].ToString();
                dateTimePicker1.Text = dataReader["deadline"].ToString();
                textBox2.Text = dataReader["description"].ToString();
                Link.Text = dataReader["link"].ToString();
                tbComment.Text = dataReader["comnentar"].ToString();
                p = dataReader["priority"].ToString();
                if (btn0.Text.CompareTo(p) == 0 ) { btn0.Checked = true; }
                else if (btn1.Text.CompareTo(p) == 0) { btn1.Checked = true; }
                else if (btn2.Text.CompareTo(p) == 0) { btn2.Checked = true; }
                else if (btn3.Text.CompareTo(p) == 0) { btn3.Checked = true; }
                else if (btn4.Text.CompareTo(p) == 0) { btn4.Checked = true; }
                s = dataReader["status"].ToString();
                if (btn0.Text.CompareTo(s) == 0) { btn0.Checked = true; }
                else if (btnOpen.Text.CompareTo(s) == 0) { btnOpen.Checked = true; }
                else if (btnProgres.Text.CompareTo(s) == 0) { btnProgres.Checked = true; }
                else if (btnFinish.Text.CompareTo(s) == 0) { btnFinish.Checked = true; }              
                i = Convert.ToInt32(String.Format("{0}", dataReader["id"]));
               
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void textBox1_TextChanged ( object sender, EventArgs e )
        {
           
        }

        private void textBox2_TextChanged ( object sender, EventArgs e )
        {

        }

        private void Link_TextChanged ( object sender, EventArgs e )
        {

        }

        private void tbComment_TextChanged ( object sender, EventArgs e )
        {

        }

        private void groupBox1_Enter ( object sender, EventArgs e )
        {

        }

        private void btnOpen_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void btnProgres_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void btnFinish_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void newData_Click ( object sender, EventArgs e )
        {

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDo;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";


            string v = dateTimePicker1.Text;
            string n = textBox1.Text;
            string p = "";
            if (btn0.Checked == true) { p = btn0.Text; } 
            else if (btn1.Checked == true) { p = btn1.Text; }
            else if (btn2.Checked == true) { p = btn2.Text; }
            else if (btn3.Checked == true) { p = btn3.Text; }
            else if (btn4.Checked == true) { p = btn4.Text; }
            string s = "";
            if (btnOpen.Checked == true) { s = btnOpen.Text; }
            else if (btnProgres.Checked == true) { s = btnProgres.Text; }
            else if (btnFinish.Checked == true) { s = btnFinish.Text; }
            string u = Link.Text;
            string d = textBox2.Text;
            string c = tbComment.Text;
            

            sql = "Insert into ToDo (name, deadline, status, priority, description, link, comnentar)values('" + n + "', '" + v + "','" + s + "','" + p + "', '" + d + "', '" + u + "', '" + c + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("New data saved!");
            command.Dispose();
            cnn.Close();

        }

        private void groupBox2_Enter ( object sender, EventArgs e )
        {

        }

        private void btn0_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void btn1_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void btn2_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void btn3_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void btn4_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void btnUpdate_Click ( object sender, EventArgs e )
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDo;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";


            string v = dateTimePicker1.Text;
            string n = textBox1.Text;
            string p = "";
            if (btn0.Checked == true) { p = btn0.Text; }
            else if (btn1.Checked == true) { p = btn1.Text; }
            else if (btn2.Checked == true) { p = btn2.Text; }
            else if (btn3.Checked == true) { p = btn3.Text; }
            else if (btn4.Checked == true) { p = btn4.Text; }
            string s = "";
            if (btnOpen.Checked == true) { s = btnOpen.Text; }
            else if (btnProgres.Checked == true) { s = btnProgres.Text; }
            else if (btnFinish.Checked == true) { s = btnFinish.Text; }
            string u = Link.Text;
            string d = textBox2.Text;
            string c = tbComment.Text;

            sql = "UPDATE ToDo SET name = '" + n + "' , deadline = '" + v + "'  ,status = '" + s + "' , priority= '" + p + "' , description = '" + d + "' , link = '" + u + "' , comnentar = '" + c + "'  WHERE id = '" + textBoxID.Text + "'";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();    
        }

        private void btnDelete_Click ( object sender, EventArgs e )
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDo;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string text = textBoxID.Text;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";           
            sql = "DELETE FROM ToDo WHERE Id = "+ text;
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Data deleted!");
            command.Dispose();
            cnn.Close();

        }

        private void dateTimePicker1_ValueChanged ( object sender, EventArgs e )
        {

        }

        private void textBoxID_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}

