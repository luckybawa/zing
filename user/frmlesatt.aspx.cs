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
            if (Request.QueryString["lcod"] != null)
            {
                Educom.clsles obj = new Educom.clsles();
      List<Educom.clslesprp> k = obj.find_rec(Convert.ToInt32
                    (Request.QueryString["lcod"]));
      Label1.Text = k[0].lestit;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clslesatt obj = new Educom.clslesatt();
        Educom.clslesattprp objprp = new Educom.clslesattprp();
     objprp.lesattlescod = Convert.ToInt32(Request.QueryString
            ["lcod"]);
     objprp.lesattnam = txtattnam.Text;
     String s = FileUpload1.PostedFile.FileName;
     if (s != "")
         s = s.Substring(s.LastIndexOf('.'));
     objprp.lesattfil = s;
     Int32 a=0;
     if (Button1.Text == "Submit")
     {
         a = obj.save_rec(objprp);
     }
   
     if (s != "")
         FileUpload1.PostedFile.SaveAs(Server.MapPath
 ("../att") + "//" + a.ToString() + s);
     txtattnam.Text = String.Empty;
     GridView1.DataBind();
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
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Educom.clslesatt obj = new Educom.clslesatt();
        Educom.clslesattprp objprp = new Educom.clslesattprp();
        objprp.lesattcod = Convert.ToInt32(GridView1.DataKeys
            [e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}