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
            Educom.clsles obj = new Educom.clsles();
            List<Educom.clslesprp> k = obj.find_rec(Convert.ToInt32
                        (Request.QueryString["lcod"]));
            Label1.Text = k[0].lestit;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Educom.clslesexr obj = new Educom.clslesexr();
        Educom.clslesexrprp objprp = new Educom.clslesexrprp();
        objprp.lesexrtit = TextBox1.Text;
        objprp.lesexrlescod = Convert.ToInt32(Request.QueryString
                                                ["lcod"]);
        Int32 a = obj.save_rec(objprp);
        Panel2.Visible = false;
        Panel1.Visible = true;
        Label2.Text = TextBox1.Text;
        ViewState["cod"] = a;
        TextBox1.Text = String.Empty;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Educom.clsqst obj = new Educom.clsqst();
        Educom.clsqstprp objprp = new Educom.clsqstprp();
        objprp.qstdsc = TextBox2.Text;
        objprp.qstlecexrcod = Convert.ToInt32(ViewState["cod"]);
        objprp.qstord = Convert.ToInt32(DropDownList1.SelectedValue);
        obj.save_rec(objprp);
        TextBox2.Text = String.Empty;
        bind();
    }
    private void bind()
    {
        Educom.clsqst obj = new Educom.clsqst();
        GridView1.DataSource = obj.disp_rec(Convert.ToInt32(
                                ViewState["cod"]));
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[GridView1
            .SelectedIndex][0]);
        ViewState["qstcod"] = a;
        Educom.clsqst obj = new Educom.clsqst();
        List<Educom.clsqstprp> k = obj.find_rec(a);
        Label3.Text = k[0].qstdsc;
        Panel3.Visible = true;
        Educom.clsopt obj1 = new Educom.clsopt();
        GridView3.DataSource = obj1.disp_rec(a);
        GridView3.DataBind();
        AjaxControlToolkit.ModalPopupExtender mpe =
            (AjaxControlToolkit.ModalPopupExtender)
  (GridView1.Rows[GridView1.SelectedIndex].FindControl
  ("lk1_ModalPopupExtender"));
        mpe.Show();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Educom.clsopt obj = new Educom.clsopt();
        Educom.clsoptprp objprp = new Educom.clsoptprp();
        objprp.optdsc = TextBox3.Text;
        objprp.optqstcod = Convert.ToInt32(ViewState["qstcod"]);
        if (CheckBox1.Checked == true)
            objprp.optsts = 'T';
        else
            objprp.optsts = 'F';
        obj.save_rec(objprp);
        TextBox3.Text = String.Empty;
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Panel2.Visible = false;
        Panel1.Visible = true;
        Label2.Text =GridView2.DataKeys[e.NewEditIndex]
                                [1].ToString();
        ViewState["cod"] = Convert.ToInt32(
            GridView2.DataKeys[e.NewEditIndex][0]);
        bind();
        e.Cancel = true;
    }
    protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Educom.clsopt obj = new Educom.clsopt();
        Educom.clsoptprp objprp = new Educom.clsoptprp();
        objprp.optcod = Convert.ToInt32(GridView3.DataKeys
            [e.RowIndex][0]);
        obj.delete_rec(objprp);
        e.Cancel = true;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        Panel1.Visible = false;
        ViewState["cod"] = null;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Educom.clsqst obj = new Educom.clsqst();
        Educom.clsqstprp objprp = new Educom.clsqstprp();
        objprp.qstcod = Convert.ToInt32(GridView1.DataKeys
            [e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Educom.clslesexr obj = new Educom.clslesexr();
        Educom.clslesexrprp objprp = new Educom.clslesexrprp();
        objprp.lesexrcod = Convert.ToInt32(GridView1.DataKeys
            [e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}