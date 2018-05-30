using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Request.QueryString["lcod"] == null)
                Response.Redirect("frmdshbrd.aspx");
            else
            {
     Educom.clsles obj = new Educom.clsles();
     List<Educom.clslesprp> k = obj.find_rec(Convert
         .ToInt32(Request.QueryString["lcod"]));
     Label2.Text = k[0].lestit;
     Literal1.Text = k[0].lesdsc;
     String fn;
     fn="../lesfil/"+k[0].lescod+k[0].lesfil;
     Session["fn"] = fn;
            }
        }
    }
 
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String s = Server.MapPath("../att") + "//" +
            GridView1.DataKeys[GridView1.SelectedIndex][0]
            + GridView1.DataKeys[GridView1.SelectedIndex][1];
        FileInfo fi = new FileInfo(s);
        if (fi.Exists == true)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition",
                "attachment;filename=" + fi.Name);
            Response.AddHeader("Content-Length", fi.Length.
                ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(fi.FullName);
            Response.End();
        }
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label3.Text = GridView2.DataKeys[e.NewEditIndex][1].ToString();
        Educom.clsqst obj = new Educom.clsqst();
        List<Educom.clsqstprp> k = obj.disp_rec(Convert.ToInt32(
            GridView2.DataKeys[e.NewEditIndex][0]));
        GridView3.DataSource = k;
        GridView3.DataBind();
   AjaxControlToolkit.ModalPopupExtender mpe= (AjaxControlToolkit.
       ModalPopupExtender)
            (GridView2.Rows[e.NewEditIndex].FindControl
            ("lk1_ModalPopupExtender"));
   mpe.Show();
   e.Cancel = true;
    }
    public List<Educom.clsoptprp> getdata(Int32 qstcod)
    {
        Educom.clsopt obj = new Educom.clsopt();
        return obj.disp_rec(qstcod);
    }
}