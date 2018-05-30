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
    public String getcat(Int32 catcod)
    {
        Educom.clscat obj = new Educom.clscat();
        List<Educom.clscatprp> k = obj.find_rec(catcod);
        return k[0].catnam;
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            char c = Convert.ToChar(GridView1.DataKeys[e.Row.RowIndex][1]);
            LinkButton lk1 = (LinkButton)(e.Row.FindControl("lk2"));
            if (c == 'N')
                lk1.Text = "Publish";
            else
                lk1.Text = "Unpublish";
            LinkButton lk3 = (LinkButton)(e.Row.FindControl("lk3"));
            LinkButton lk4 = (LinkButton)(e.Row.FindControl("lk4"));
            if (c == 'P')
            {
                lk3.Visible = true;
                lk4.Visible = true;
            }
            else
            {
                lk3.Visible = false;
                lk4.Visible = false;
            }
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys
            [e.NewEditIndex][0]);
        Response.Redirect("frmaddles.aspx?ccod=" + a.ToString());
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("frmstu.aspx?ccod=" + GridView1.DataKeys
            [GridView1.SelectedIndex][0]);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmcrtles.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Educom.clslescol obj = new Educom.clslescol();
     Educom.clslescolprp objprp = new Educom.clslescolprp();
     objprp.lescolcod = Convert.ToInt32(GridView1.DataKeys
         [e.RowIndex][0]);
     if (Convert.ToChar(GridView1.DataKeys[e.RowIndex][1])
         == 'P')
         objprp.lescolpubsts = 'N';
     else
         objprp.lescolpubsts = 'P';
     obj.updlescolsts(objprp);
     GridView1.DataBind();
     e.Cancel = true;
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("frmrep.aspx?ccod=" +
            GridView1.DataKeys[e.RowIndex][0]);
    }
}