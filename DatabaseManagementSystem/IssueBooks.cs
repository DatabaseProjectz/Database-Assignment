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

                    cmd.CommandText = "SELECT * FROM Borrower WHERE M_ID = '" + Mid + "' ";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        txtMemberName.Text = DS.Tables[0].Rows[0][1].ToString();
                        txtEmail.Text = DS.Tables[0].Rows[0][3].ToString();
                        txtContactNo.Text = DS.Tables[0].Rows[0][4].ToString();
                    }
                    else
                    {
                        txtMemberName.Clear();
                        txtContactNo.Clear();
                        txtEmail.Clear();
                        MessageBox.Show("Invalid Member ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please input Member ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error detected :" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtISBN.Text == "")
                {
                    MessageBox.Show("Please input all details!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-VHPDJKD; database=LibraryManagementSystem; Integrated security=True";
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO IssueInfo(B_ISBN, CopyNo, Member_ID, Fine, IssueDate, ReturnDate) VALUES ('" + txtISBN.Text + "' , '" + txtCopyNo.Text + "' , '" + txtMemberID.Text + "' , '" + "" + "' , '" + tdpBookIssue.Value.ToString("MM/dd/yyyy") + "' , '" + tdpBookReturn.Value.ToString("MM/dd/yyyy") + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued Successfully!", "Congradulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detected :" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckCopyNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtISBN.Text != "")
                {
                    String isbn = txtISBN.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-VHPDJKD; database=LibraryManagementSystem; Integrated security=True";
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ISBN, B_Author, B_Name, B_Publisher, Copy.CopyNo FROM Book, Copy WHERE Book.ISBN = Copy.Copy_ISBN AND ISBN = '" + isbn + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DA.Fill(dt);
                    dgvBookDetails.DataSource = dt;
                    con.Close();
                    
                    dgvBookDetails.Show();

                    tdpBookReturn.Value = tdpBookIssue.Value.AddDays(14);
                }
                else
                {
                    dgvBookDetails.Rows.Clear();
                    MessageBox.Show("Please Input Copy No!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error detected :" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "")
            {
                txtMemberName.Text = "";
                txtContactNo.Text = "";
                txtEmail.Text = "";
                txtISBN.Text = "";
                txtCopyNo.Text = "";
                dgvBookDetails.Hide();
            }
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
