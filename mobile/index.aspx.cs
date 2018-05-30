using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clsusr obj = new Educom.clsusr();
        Int32 a;
        char rol;
   a = obj.logincheck(TextBox1.Text, TextBox2.Text, out rol);
   if (a == -1)
       Label1.Text = "Email Password Incorrect";
   else
   {
       FormsAuthenticationTicket tk = new FormsAuthenticationTicket(1,
           TextBox1.Text, DateTime.Now, DateTime.Now.AddHours(2), false, 
           rol.ToString());
       String s = FormsAuthentication.Encrypt(tk);
       HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName, s);
       Response.Cookies.Add(ck);

       Session["cod"] = a;
       if (rol == 'U')
           Response.Redirect("user/frmsrcles.aspx");
       else if (rol == 'A')
           Response.Redirect("admin/frmcat.aspx");
   }
    }
}