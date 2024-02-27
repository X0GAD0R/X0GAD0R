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

namespace ManageEmployers
{
    public partial class Managing : Form
    {
        int move;
        int movx;
        int movy;
        SqlDataAdapter da = new SqlDataAdapter();

        public Managing()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Administrator\Desktop\programing\project c#\ManageEmployers\ManageEmployers\DBEmployees.mdf"";Integrated Security=True");
        void populate()
        {
            con.Open();
            string sql = "select * from EMPLOYEES";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();

        }

        private void Managing_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var sql = "SELECT ID, NAME, EMAIL, JOB FROM EMPLOYEES";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            Form addformemployees = new AddFormEmployees();
            addformemployees.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelUpMng_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void PanelUpMng_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void PanelUpMng_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx,MousePosition.Y - movy);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
