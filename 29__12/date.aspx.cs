using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _29_12
{
    public partial class date : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (Request.Cookies["labelColor"] != null)
            {
                string cookie = Request.Cookies["labelColor"]["color"];

                switch (cookie)
                {
                    case "black":
                        lblDateTime.ForeColor = System.Drawing.Color.Black;
                        break;
                    case "yellow":
                        lblDateTime.ForeColor = System.Drawing.Color.Yellow;
                        break;
                    case "green":
                        lblDateTime.ForeColor = System.Drawing.Color.Green;
                        break;
                    case "blue":
                        lblDateTime.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "red":
                        lblDateTime.ForeColor = System.Drawing.Color.Red;
                        break;
                    default:
                        lblDateTime.ForeColor = System.Drawing.Color.Black;
                        break;
                }

            }




        }

        protected void ddlColors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("labelColor");
            cookie.Values.Add("color", ddlColors.SelectedValue);
            cookie.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);
            Response.Cookies["labelColor"].Expires = DateTime.Now.AddDays(7);
            string color = Request.Cookies["labelColor"]["color"];




            switch (color)
            {
                case "yellow":
                    lblDateTime.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case "green":
                    lblDateTime.ForeColor = System.Drawing.Color.Green;
                    break;
                case "blue":
                    lblDateTime.ForeColor = System.Drawing.Color.Blue;
                    break;
                case "red":
                    lblDateTime.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    lblDateTime.ForeColor = System.Drawing.Color.Black;
                    break;
            }

        }
    }
}