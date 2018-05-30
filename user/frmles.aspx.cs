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
        if (Page.IsPostBack == false)
        {
            if (Request.QueryString["ccod"] == null)
                Response.Redirect("frmsrcles.aspx");
            else
            {
                Educom.clscat obj = new Educom.clscat();
                List<Educom.clscatprp> k = obj.find_rec(Convert.ToInt32
                                            (Request.QueryString["ccod"]));
                Label1.Text = k[0].catnam;
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmcrtles.aspx");
    }
}