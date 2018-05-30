using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            Educom.clscat obj = new Educom.clscat();
  List<Educom.clscatprp> k = obj.find_rec(Convert.ToInt32
                (Request.QueryString["ccod"]));
  Educom.clslescol obj1 = new Educom.clslescol();
  DataSet ds = obj1.srclescol(k[0].catcod);
  Label lbl = (Label)(e.Row.FindControl("Label1"));
  lbl.Text = k[0].catnam + " (" +
      ds.Tables[0].Rows.Count.ToString() + ")";
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("frmlesdet.aspx?lccod=" +
            GridView1.DataKeys[e.NewEditIndex][0]);
    }
}