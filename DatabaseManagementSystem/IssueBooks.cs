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
        int count = 0;

        public IssueBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ISSUE_Load(object sender, EventArgs e)
        {/*
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
            con.Close();*/
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
                    MessageBox.Show("Please input Member ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error detected :" + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            
            int b = dgvIssuedBooks.RowCount;
            label1.Text = b.ToString();

            //count++;
            //txtIssueNo.Text = count.ToString();

            try
            {
                if (txtISBN.Text == "")
                {
                    MessageBox.Show("Please input all details!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-VHPDJKD; database=LibraryManagementSystem; Integrated security=True";
                    con.Open();
                    
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO IssueInfo(IssueNo, Book_ISBN, CopyNo, Member_ID, Fine, Quantity, IssueDate, ReturnDate) VALUES ('" + txtIssueNo.Text + "' , '" + txtISBN.Text + "' , '" + txtCopyNo.Text + "' , '" + txtMemberID.Text + "' , '" + 0.00 + "' , '" + dgvIssuedBooks.RowCount.ToString() + "' , '" + tdpBookIssue.Value.ToString("MM/dd/yyyy") + "' , '" + tdpBookReturn.Value.ToString("MM/dd/yyyy") + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Congradulations!" , "Book Issued Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detected :" + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);            
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
                    cmd.CommandText = "SELECT ISBN, Book_Name, Book_Author_Name, Book_Publication, Copy.CopyNo FROM Book, Copy WHERE Book.ISBN = Copy.Copy_ISBN AND ISBN = '" + isbn + "' ";
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
                MessageBox.Show("Error detected :" + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvIssuedBooks.Rows.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCopyNo.Text != "")
            {
                dgvIssuedBooks.Show();
                dgvIssuedBooks.Rows.Add(txtCopyNo.Text);

                //dgvIssuedBooks.Rows.Add(dgvBookDetails.SelectedColumns.ToString());
            } 
            else
            {
                MessageBox.Show("Please input Copy No before adding!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
