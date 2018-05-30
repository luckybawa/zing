using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class user_MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["colcod"] == null)
            Response.Redirect("frmprf.aspx");
        else
        {
        Educom.clslescol obj = new Educom.clslescol();
 List<Educom.clslescolprp> k = obj.find_rec(Convert.ToInt32(Session["colcod"]));
 Label1.Text = k[0].lescoltit;
        }
    }
    protected void lk1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        FormsAuthentication.SignOut();
        FormsAuthentication.RedirectToLoginPage();
    }
    protected void lk2_Click(object sender, EventArgs e)
    {
        Session["colcod"] = null;
        Response.Redirect("frmsrcles.aspx");
    }
}
