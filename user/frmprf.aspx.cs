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
            Educom.clsprf obj = new Educom.clsprf();
            List<Educom.clsprfprp> k = obj.find_rec(Convert.ToInt32
                (Session["cod"]));
            if (k.Count > 0)
            {
                TextBox1.Text = k[0].prffstnam;
                TextBox2.Text = k[0].prflstnam;
                TextBox3.Text = k[0].prfdsc;
                ViewState["pic"] = k[0].prfpic;
                Button1.Text = "Update";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clsprf obj = new Educom.clsprf();
        Educom.clsprfprp objprp = new Educom.clsprfprp();
        objprp.prffstnam = TextBox1.Text;
        objprp.prflstnam = TextBox2.Text;
        objprp.prfdsc = TextBox3.Text;
        objprp.prfcod = Convert.ToInt32(Session["cod"]);
        String s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        if (s == ""  && Button1.Text == "Update")
            objprp.prfpic = ViewState["pic"].ToString();
        else
            objprp.prfpic = s;
        if (Button1.Text == "Submit")
            obj.save_rec(objprp);
        else
            obj.update_rec(objprp);
        if (s != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../prfpics")
                + "//" + Session["cod"] + s);
    }
}