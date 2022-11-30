using System.Data;
using System.Data.SqlClient;

namespace CSharpAssignment
{
    public partial class Form1 : Form
    {
        SqlConnection data = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CSharpAssignment;user id=sa;password=admin;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.Open();
            string query = "Select * from employeeData";
            SqlCommand sqlCommand = new SqlCommand(query, data);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            data.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               /* string uName = getName.Text;
                string uAddress = getAddress.Text;
                string uSalary = getSalary.Text;*/
                data.Open();
                string query = "Insert into employeeData values('" + this.getName.Text + 
                    "','" + this.getAddress.Text + "','" + this.getSalary.Text + "')";
                SqlCommand cmd = new SqlCommand(query, data);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Sucessfully");
                data.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error!! : " + ex.InnerException); }
        }

        private void getName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dataGridView1.Rows.Add(getId.Text,getName.Text, getAddress.Text, getSalary.Text);*/
            data.Open();
            string query = "Select * from employeeData";
            SqlCommand sqlCommand = new SqlCommand(query, data);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            data.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                data.Open();
                string query = "delete from employeeData where id = '"+this.getId.Text +"'";
                SqlCommand cmd = new SqlCommand(query, data);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Sucessfully");
                data.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error!! : " + ex.InnerException); }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                /* string uName = getName.Text;
                 string uAddress = getAddress.Text;
                 string uSalary = getSalary.Text;*/
                data.Open();
                string query = "INSERT INTO Student (LastName, FirstName, Address, City)  VALUES(@ln, @fn, @add, @cit)";
                SqlCommand cmd = new SqlCommand(query, data);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Sucessfully");
                data.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error!! : " + ex.InnerException); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}