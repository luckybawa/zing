using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clsusr obj = new Educom.clsusr();
        Int32 a = obj.chgpwd(Convert.ToInt32(Session["cod"]),
            TextBox1.Text, TextBox2.Text);
        if (a == 0)
            Label2.Text = "Old Password Incorrect";
        else if (a == 1)
            Label2.Text = "Password Updated Successfully"; 
    }
}