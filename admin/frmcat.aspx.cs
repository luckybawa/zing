using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clscat obj = new Educom.clscat();
        Educom.clscatprp objprp = new Educom.clscatprp();
        objprp.catnam = TextBox1.Text;
        String s;
        s = FileUpload1.PostedFile.FileName;
        if (s != "")
        {
            s = s.Substring(s.LastIndexOf('.'));
        }
        objprp.catpic = s;
        if (Button1.Text == "Submit")
        {
            Int32 a = obj.save_rec(objprp);
            if (s != "")
                FileUpload1.PostedFile.SaveAs(Server.MapPath
("../catpics") + "//" + a.ToString() + s);
        }
        else
        {
            objprp.catcod = Convert.ToInt32(ViewState["cod"]);
            if (s == "")
                objprp.catpic = ViewState["pic"].ToString();
            obj.update_rec(objprp);
            if (s != "")
                FileUpload1.PostedFile.SaveAs(Server.MapPath
        ("../catpics") + "//" + ViewState["cod"].ToString() + s);
            Button1.Text = "Submit";
        }
        GridView1.DataBind();
        TextBox1.Text = String.Empty;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Educom.clscat obj = new Educom.clscat();
        Educom.clscatprp objprp = new Educom.clscatprp();
        objprp.catcod = Convert.ToInt32(GridView1.DataKeys
            [e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.
            NewEditIndex][0]);
        Educom.clscat obj = new Educom.clscat();
        List<Educom.clscatprp> k = obj.find_rec(a);
        TextBox1.Text = k[0].catnam;
        ViewState["pic"] = k[0].catpic;
        ViewState["cod"] = k[0].catcod;
        Button1.Text = "Update";
        e.Cancel = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = String.Empty;
        Button1.Text = "Submit";
    }
}