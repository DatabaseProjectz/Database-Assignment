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

namespace DatabaseManagementSystem
{
    public partial class ISSUE : Form
    {
        public ISSUE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ISSUE_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VHPDJKD; database=library; Integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("SELECT bName FROM NewBook", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read())
            {
                for(int i=0; i<sdr.FieldCount; i++)
                {
                    cmbBookName.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtIsbnNo.Text != "")
            {
                String eid = txtIsbnNo.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-VHPDJKD; database=library; Integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM NewStudent WHERE ISBN_No = '"+ eid +"' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if(DS.Tables[0].Rows.Count != 0)
                {
                    txtStudentName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtFaculty.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtStudentBatch.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtStudentContactNo.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtStudentEmail.Text = DS.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtStudentName.Clear();
                    txtFaculty.Clear();
                    txtStudentBatch.Clear();
                    txtStudentContactNo.Clear();
                    txtStudentEmail.Clear();
                    MessageBox.Show("Invalid ISBN NO!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
