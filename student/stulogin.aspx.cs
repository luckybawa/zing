using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class student_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clsstu obj = new Educom.clsstu();
        Int32 a = obj.logstu(txtusrnam.Text, txtpwd.Text);
        if (a == -1)
            Label1.Text = "Username Password Incorrect";
        else
        {
            Session["stucod"] = a;
            Response.Redirect("frmstudet.aspx");
        }
    }
}