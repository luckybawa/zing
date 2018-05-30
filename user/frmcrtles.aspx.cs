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
        Educom.clslescol obj = new Educom.clslescol();
        Educom.clslescolprp objprp = new Educom.clslescolprp();
        objprp.lescoltit = TextBox1.Text;
        objprp.lescoldsc = TextBox2.Text;
        objprp.lescolsec = TextBox4.Text;
        objprp.lescolusrcod = Convert.ToInt32(Session["cod"]);
        objprp.lescolcatcod = Convert.ToInt32(DropDownList1
                        .SelectedValue);
        objprp.lescolcst = Convert.ToSingle(TextBox3.Text);
        objprp.lescoldat = DateTime.Now;
        if (CheckBox1.Checked == true)
            objprp.lescolpubsts = 'P';
        else
            objprp.lescolpubsts = 'N';
        String s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.lescolpic = s;
        Int32 a = obj.save_rec(objprp);
        if (s != "")
            FileUpload1.PostedFile.SaveAs(
  Server.MapPath("../lescol") + "//" + a.ToString() + s);
        Response.Redirect("frmmycol.aspx");
    }
}