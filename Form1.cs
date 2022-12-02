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

            /*try
            {
                data.Open();
                string query = "Insert into employeeData values('"+this.getId1.Text +"','" + this.getName.Text + 
                    "','" + this.getAddress.Text + "','" + this.getSalary.Text + "')";
                SqlCommand cmd = new SqlCommand(query, data);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Sucessfully");
                data.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error!! : " + ex.InnerException); }*/
            try
            {
                data.Open();
                string query = "Insert into employeeData" +
                    "(id,employeeName,elpmoyeeAddress,employeeSalary)" +
                    "values(@Id, @Name, @Address, @Salary)";
                SqlCommand cmd = data.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id", getId1.Text);
                cmd.Parameters.AddWithValue("@Name", getName.Text);
                cmd.Parameters.AddWithValue("@Address", getAddress.Text);
                cmd.Parameters.AddWithValue("@Salary", getSalary.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Sucessfully");
                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!! : " + ex.Message);
            }
        }

        private void getName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dataGridView1.Rows.Add(getId.Text, getName.Text, getAddress.Text, getSalary.Text);
            data.Open();
            string query = "Select * from employeeData";
            SqlCommand sqlCommand = new SqlCommand(query, data);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            data.Close();*/


            //second method
            string query = "Select * from employeeData";
            SqlCommand sqlCommand = new SqlCommand(query, data);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string adt_id = dt.Rows[i]["id"].ToString();
                string adt_name = dt.Rows[i]["employeeName"].ToString();
                string adt_address = dt.Rows[i]["elpmoyeeAddress"].ToString();
                string adt_salary = dt.Rows[i]["employeeSalary"].ToString();
                dataGridView1.Rows.Add(adt_id, adt_name, adt_address, adt_salary);

            }
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
                string uName = getName.Text;
                string uAddress = getAddress.Text;
                string uSalary = getSalary.Text;
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

        private void button5_Click(object sender, EventArgs e)
        {
            //Findng data through Database
            data.Open();
            string query = "Select * from employeeData where id = '" + this.getId.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, data);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string dId = dt.Rows[0]["id"].ToString();
                string dName = dt.Rows[0]["employeeName"].ToString();
                string dAddress = dt.Rows[0]["elpmoyeeAddress"].ToString();
                string dSalary = dt.Rows[0]["employeeSalary"].ToString();
                getId1.Text = dId;
                getName.Text = dName;
                getAddress.Text = dAddress;
                getSalary.Text = dSalary;
            }
            data.Close();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void dataGridShow_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow data = dataGridView1.CurrentRow;
            string emp_id = data.Cells["id"].Value.ToString();
            string emp_name = data.Cells["employeeName"].Value.ToString();
            string emp_address = data.Cells["elpmoyeeAddress"].Value.ToString();
            string emp_salary = data.Cells["employeeSalary"].Value.ToString();

            getId1.Text = emp_id;
            getName.Text = emp_name;
            getAddress.Text = emp_address;
            getSalary.Text = emp_salary;*/
        }
    }
}