using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Diya\source\repos\Pract12\Pract12\App_Data\Database1.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from student", conn);

            SqlDataReader reader = cmd.ExecuteReader(); 

            GridView1.DataSource = reader;
            GridView1.DataBind();

            conn.Close();
        }
    }
}