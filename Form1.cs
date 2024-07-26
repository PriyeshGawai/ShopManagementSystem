using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Project\\visual studio\\LoginPage\\WinFormsApp1\\Login.mdf\";Integrated Security=True");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            cmd = con.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "select * from resistration where username='"+ textBox1.Text +"'and password='"+textBox2.Text+"'";
           
            DataTable dt=new DataTable (); 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill (dt);
            i=Convert.ToInt32(dt.Rows.Count);

            if (i == 0)
            {
                MessageBox.Show("This Username Password is not match!");
            }
            else
            {
                this.Hide();
                MDIParent1 mDIParent1 = new MDIParent1 ();
                mDIParent1.Show();
            }
        }
    }
}
