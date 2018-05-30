<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmpay.aspx.cs" Inherits="frmpayment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body onload="document.getElementById('btntest').click();">

<form action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
    <input type="hidden" name="cmd" value="_xclick" />
    <input type="hidden" name="Personal" value="cssoft@sify.com" />    
    <input type="hidden" name="business" value="Bishop_1346927984_biz@csknowledgehub.com" />
    <input type="hidden" name="item_name" value='Enrollment Fee' />
    <input type="hidden" name="amount" value='<%=Session["amt"]%>' /> 
    <input type="hidden" name="return" value="http://educom.csgroupstaging.com/user/confirm.aspx" />
    <input type="hidden" name="cancel_return" value="http://www.eventful.csgroupstaging.com/user/cancel_confirm.aspx" />
    <input type="hidden" name="rm" value="2" />
   
    <input type="submit" style="display:none;" id="btntest" value="Buy with additional parameters!" /> 
    Please wait...............
    </form>
</body>
</html>
