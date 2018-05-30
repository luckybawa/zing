using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clsusr obj = new Educom.clsusr();
        Educom.clsusrprp objprp = new Educom.clsusrprp();
        objprp.usreml = txteml.Text;
        objprp.usrpwd = txtpwd.Text;
        objprp.usrrol = 'U';
        objprp.usrdat = DateTime.Now;
        try
        {
            obj.save_rec(objprp);
            Label1.Text = "Registration Successful";
            txteml.Text = String.Empty;
        }
        catch (Exception exp)
        {
            Label1.Text = "Email ID already registered";
        }
    }
}