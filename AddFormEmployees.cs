using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace ManageEmployers
{
    public partial class AddFormEmployees : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        int move;
        int movx;
        int movy;
        public AddFormEmployees()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx,MousePosition.Y - movy) ;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
           MemoryStream ma = new MemoryStream();
            pictureBox.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
            var _cover = ma.ToArray();

            if(TextBoxName.Text != "" && textBoxEmail.Text != "" &&  textBoxPhnmbr.Text != "" && textBoxJob.Text != "")
            {
                con = new SqlConnection(@"C:\USERS\ADMINISTRATOR\DESKTOP\PROGRAMING\PROJECT C#\MANAGEEMPLOYERS\MANAGEEMPLOYERS\DBEMPLOYEES.MDF");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO EMPLOYEES (Name,Phone number,Email,Job,Cover) VALUES (@Name,@Phone number,@Email,@Job,@Cover)";
                cmd.Parameters.AddWithValue("@Name", TextBoxName.Text);
                cmd.Parameters.AddWithValue("@Phone number", textBoxPhnmbr.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Job", textBoxJob.Text);
                cmd.Parameters.AddWithValue("@Cover", pictureBox.Image);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add successfully");
                this.Close();
            }
            else if(TextBoxName.Text == "")
            {
                MessageBox.Show("You need to enter your name");
            }

            else if(textBoxPhnmbr.Text == "")
            {
                MessageBox.Show("You need to enter your phone number");
            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("You need to enter your Email");
            }
            else if (textBoxJob.Text == "")
            {
                MessageBox.Show("You need to enter your ");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox.Image=Image.FromFile(dia.FileName);
            }
        }
    }
}
