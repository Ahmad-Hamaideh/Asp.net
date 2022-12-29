using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _29_12
{
    public partial class login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if there is a cookie stored with the user's credentials
            HttpCookie cookie = Request.Cookies["userCredentials"];
            if (cookie != null)
            {
                // If there is a cookie, retrieve the username and password from the cookie
                // and pre-fill the login form with the retrieved values
                TextBox1.Text = cookie["username"];
                txtPassword.Text = cookie["password"];
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check if the "Remember me" checkbox is checked
            if (chkRememberMe.Checked)
            {
                // If it is, create a new cookie and save the user's username and password in the cookie
                HttpCookie cookie = new HttpCookie("userCredentials");
                cookie["username"] = TextBox1.Text;
                cookie["password"] = txtPassword.Text;
                cookie.Expires = DateTime.Now.AddDays(10);  // Set the cookie to expire in 30 days
                Response.Cookies.Add(cookie);
                //Response.Redirect("dateTime.aspx");

            }

            // Perform the login process (e.g. validate the username and password, redirect to the dashboard, etc.)
            // ...
        }
    }
}