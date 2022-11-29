using System.Data.SqlClient;
namespace CSharpAssignment
{
    public partial class Form1 : Form
    {
        SqlConnection data = new SqlConnection(@"Data Source=LAPTOP-3ORSUC9H;Initial Catalog=CSharpAssignment;user id=sa;password=@admin123;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                string query = "Insert into employeeData values('" + this.getName.Text + "','" + this.getAddress.Text + "','" + this.getSalary.Text + "')";
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
    }
}