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
        Educom.clsdis obj = new Educom.clsdis();
        Educom.clsdisprp objprp = new Educom.clsdisprp();
        objprp.disrep = TextBox2.Text ;
        objprp.discod = Convert.ToInt32(ViewState["cod"]);
        obj.update_rec(objprp);
        TextBox2.Text = String.Empty;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lk1 = (LinkButton)(e.Row.FindControl("lk1"));
            if (GridView1.DataKeys[e.Row.RowIndex][1].ToString() != "")
                lk1.Visible = false;
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        ViewState["cod"] = a;
        AjaxControlToolkit.ModalPopupExtender mpe =
            (AjaxControlToolkit.ModalPopupExtender)(GridView1.Rows
            [e.NewEditIndex].FindControl("lk1_ModalPopupExtender"));
        mpe.Show();
        e.Cancel = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = string.Empty;
        Panel1.Visible = false;
       
    }
}