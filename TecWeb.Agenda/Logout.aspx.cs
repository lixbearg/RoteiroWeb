using System;
using System.Web;

namespace TecWeb.Agenda
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            HttpCookie cookie = new HttpCookie("Usuario");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default.aspx");
        }
    }
}