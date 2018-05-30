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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clsstu obj = new Educom.clsstu();
        Educom.clsstuprp objprp = new Educom.clsstuprp();
        objprp.stunam = txtstunam.Text;
        objprp.sturolno = txtrolno.Text;
        if (TextBox1.Visible == false)
            objprp.stucol = DropDownList1.SelectedItem.Text;
        else
            objprp.stucol = TextBox1.Text;
        objprp.stutrgstrdat = Convert.ToDateTime(txttrgstrdat.Text);
        objprp.stutrgenddat = Convert.ToDateTime(txttrgenddat.Text);
        objprp.stuusrnam = "cssoft";
        String pwd = Guid.NewGuid().ToString();
        pwd = pwd.Substring(0, 10);
        objprp.stupwd = pwd;
        String s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.stupic = s;
        Int32 a = obj.save_rec(objprp);
        Label1.Text = "cssoft" + a.ToString();
        Label2.Text = pwd;
        if (s != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("stupics") + "//" + a.ToString()
                + s);
        txtrolno.Text = String.Empty;
        txtstunam.Text = String.Empty;
        txttrgenddat.Text = String.Empty;
        txttrgstrdat.Text = String.Empty;
        Label3.Text = "Record stored successfully";
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "OTHERS")
            TextBox1.Visible = true;
        else
            TextBox1.Visible = false;
    }
}