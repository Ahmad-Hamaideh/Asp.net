using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace _28_12
{
    public partial class task : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);

           
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source = DESKTOP-56DD5MG\\SQLEXPRESS; database=ajax; integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand($"insert into task  (commint) values('{TextBox2.Text}')", con);
                cm.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successalert();", true);
                string selct = "select * from task";
                SqlCommand cm2 = new SqlCommand(selct, con);
                SqlDataReader rd = cm2.ExecuteReader();
                Label1.Text = "<table class='table table-striped' style='width:80%;'> <h5 style='color:#d94125; margin:20px'> your comment </h5>";
                while (rd.Read())
                {
                    Label1.Text += /*rr[1]*/
                        $"<tr> <td>{rd[0]}</td> <td>{rd[1]}</td></tr>";
                }
                Label1.Text +=
                    "</table>";
                con.Close();


            catch { }


        }
    }
}