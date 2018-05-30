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
        if (Session["stucod"] != null)
        {
            Educom.clsstu obj = new Educom.clsstu();
            List<Educom.clsstuprp> k = obj.find_rec(Convert.ToInt32
                (Session["stucod"]));
            Label1.Text = k[0].stunam;
            Label2.Text = k[0].stucol;
            Label3.Text = k[0].sturolno;
            Label4.Text = k[0].stutrgstrdat.ToShortDateString();
            Label5.Text = k[0].stutrgenddat.ToShortDateString();
            Image1.ImageUrl = "~/student/stupics/" + k[0].stucod.ToString()
                + k[0].stupic;

        }
        else
            Response.Redirect("stulogin.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../index.aspx");
    }
}