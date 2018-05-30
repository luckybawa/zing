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
                Response.Redirect("frmmycol.aspx");
            else
            {
      Educom.clslescol obj = new Educom.clslescol();
      List<Educom.clslescolprp> k = obj.find_rec(Convert
          .ToInt32(Request.QueryString["ccod"]));
      Label1.Text = k[0].lescoltit;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clsles obj = new Educom.clsles();
        Educom.clslesprp objprp = new Educom.clslesprp();
        objprp.lestit = txtlestit.Text;
        objprp.lesdsc = txtdsc.Text;
        objprp.leslescolcod = Convert.ToInt32(Request
                        .QueryString["ccod"]);
        objprp.lesord = Convert.ToChar(DropDownList1.SelectedValue);
        objprp.lestim = txtlestim.Text;
        String s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.lesfil = s;
        Int32 a = obj.save_rec(objprp);
        if (s != "")
   FileUpload1.PostedFile.SaveAs(Server.MapPath("../lesfil")
                + "//" + a.ToString() + s);
        txtlestit.Text = String.Empty;
        txtlestim.Text = String.Empty;
        txtdsc.Text = String.Empty;
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("frmlesatt.aspx?lcod=" +
            GridView1.DataKeys[GridView1.SelectedIndex][0]);
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Response.Redirect("frmlesexr.aspx?lcod=" +
            GridView1.DataKeys[e.RowIndex][0]);
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Educom.clsles obj = new Educom.clsles();
        Educom.clslesprp objprp = new Educom.clslesprp();
        objprp.lescod = Convert.ToInt32(GridView1.DataKeys
            [e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}