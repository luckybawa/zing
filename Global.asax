<%@ Application Language="C#" %>
<%@ Import Namespace ="System.Security.Principal" %>
<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    void Application_AuthenticateRequest(object sender, EventArgs e)
    {
        if (HttpContext.Current.User != null)
        {
            FormsIdentity id = (FormsIdentity)(User.Identity);
            String s = id.Ticket.UserData;
            String[] r = s.Split(',');
            HttpContext.Current.User = new GenericPrincipal(id, r);
        }
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
        HttpRequest httpRequest = HttpContext.Current.Request;
        if (httpRequest.Browser.IsMobileDevice)
        {
            string path = httpRequest.Url.PathAndQuery;
            bool isOnMobilePage = path.StartsWith(
       "/Mobile/", StringComparison.OrdinalIgnoreCase);
            if (!isOnMobilePage)
            {
                string redirectTo = "~/Mobile/index.aspx";
                HttpContext.Current.Response.Redirect(redirectTo);
            }
        }
        
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
