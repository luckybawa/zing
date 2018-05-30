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
        if (Page.IsPostBack == false)
        {
            if (Request.QueryString["lccod"] == null)
                Response.Redirect("frmsrcles.aspx");
            else
            {
        Educom.clslescol obj = new Educom.clslescol();
 DataSet ds = obj.lescoldet(Convert.ToInt32(Request
            .QueryString["lccod"]));
 Label1.Text = ds.Tables[0].Rows[0]["lescoltit"].ToString();
 Label2.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["lescoldat"]).ToShortDateString();
 Label3.Text = "$" +ds.Tables[0].Rows[0]["lescolcst"].ToString();
 Label4.Text = ds.Tables[0].Rows[0]["nor"].ToString();
 Label5.Text = ds.Tables[0].Rows[0]["catnam"].ToString();
 Literal1.Text = ds.Tables[0].Rows[0]["lescolsec"].ToString();
 Literal2.Text = ds.Tables[0].Rows[0]["lescoldsc"].ToString();
 Image1.ImageUrl = "~/lescol/" + ds.Tables[0].Rows[0]["lescolcod"].ToString()
     + ds.Tables[0].Rows[0]["lescolpic"].ToString();
 Image2.ImageUrl = "~/prfpics/" + ds.Tables[0].Rows[0]["prfcod"].ToString()
     + ds.Tables[0].Rows[0]["prfpic"].ToString();
 Label6.Text = ds.Tables[0].Rows[0]["nam"].ToString();
 Label7.Text = ds.Tables[0].Rows[0]["prfdsc"].ToString();
 DataList1.DataSource = obj.dspusrlescol(
     Convert.ToInt32(ds.Tables[0].Rows[0]["prfcod"]),
     Convert.ToInt32(Request.QueryString["lccod"]));
 DataList1.DataBind();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 a = Convert.ToInt32(Label3.Text.Substring(1));
        Session["amt"] = Label3.Text.Substring(1);
        Session["lccod"] = Request.QueryString["lccod"];
        if (a != 0)
            Response.Redirect("frmpay.aspx");
        else
            Response.Redirect("confirm.aspx");
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}