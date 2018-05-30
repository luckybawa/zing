<%@ Page Title="" Language="C#" MasterPageFile="~/student/MasterPage.master" AutoEventWireup="true" CodeFile="stulogin.aspx.cs" Inherits="student_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
 <section class="login-area">
          <section class="login-head"> <img class="key" src="images/key-img.png">
            <h3>Login to your account </h3>
            <div class="clearfix"></div>
          </section>
          <section class="login">
        
            <label class="label-text" >Username</label>
              <asp:TextBox ID="txtusrnam" runat="server" CssClass ="input-field"></asp:TextBox>
            <div class="clearfix"></div>
            <label class="label-text">Password</label>
              <asp:TextBox ID="txtpwd" runat="server" CssClass ="input-field" TextMode="Password"></asp:TextBox>
            <div class="clearfix"></div>
              <asp:Button ID="Button1" runat="server" Text="Login"  CssClass ="login-btn" OnClick="Button1_Click"/>
   <div class="clearfix"></div>
             <div class="clearfix">
                 <h5>
                     <asp:Label ID="Label1" runat="server"></asp:Label>
                 </h5>
              </div>
             
            <div class="clearfix"></div>
          </section>
            <div class="site-link"> 
                <a style="float:left;" href="http://www.cssoftsolutions.com/">Visit CS SoftSolutions Website</a>&nbsp; <div class="clearfix"></div></div>
        </section>
        
   
        
</asp:Content>

