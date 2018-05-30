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
        Educom.clsdis obj = new Educom.clsdis();
        Educom.clsdisprp objprp = new Educom.clsdisprp();
        objprp.disdat = DateTime.Now;
        objprp.disdsc = TextBox2.Text;
        objprp.disleccod = Convert.ToInt32(Session["colcod"]);
        objprp.disrep = "";
        objprp.distit = TextBox1.Text;
        objprp.disusrcod = Convert.ToInt32(Session["cod"]);
        obj.save_rec(objprp);
        TextBox1.Text = String.Empty;
        TextBox2.Text = String.Empty;
        GridView1.DataBind();
    }
}