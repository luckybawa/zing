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
            if (Session["amt"] != null)
            {
      Educom.clsenr obj = new Educom.clsenr();
      Educom.clsenrprp objprp = new Educom.clsenrprp();
      objprp.enrdat = DateTime.Now;
      objprp.enrlescolcod = Convert.ToInt32
          (Session["lccod"]);
      objprp.enrusrcod = Convert.ToInt32(Session["cod"]);
      obj.save_rec(objprp);
      Session["amt"] = null;
      Session["lccod"] = null;
      Response.Redirect("frmpurles.aspx");
            }
        }
    }
}