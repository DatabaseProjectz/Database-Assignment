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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
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
            con.ConnectionString = "data source = DESKTOP-VHPDJKD; database=LibraryManagementSystem; Integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("SELECT Book_Name FROM Book", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    cmbBookName.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberID.Text != "")
                {
                    String Mid = txtMemberID.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-VHPDJKD; database=LibraryManagementSystem; Integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT * FROM Borrower WHERE Member_ID = '" + Mid + "' ";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        txtMemberName.Text = DS.Tables[0].Rows[0][1].ToString();                        
                        txtContactNo.Text = DS.Tables[0].Rows[0][2].ToString();
                        txtEmail.Text = DS.Tables[0].Rows[0][3].ToString();
                        txtCopyNo.Text = DS.Tables[0].Rows[0][4].ToString();
                    }
                    else
                    {
                        txtMemberName.Clear();
                        txtContactNo.Clear();
                        txtEmail.Clear();
                        txtCopyNo.Clear();
                        MessageBox.Show("Invalid Member ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please input Member ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "\n\n Please check your database details!" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
