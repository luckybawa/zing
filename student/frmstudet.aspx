<%@ Page Title="" Language="C#" MasterPageFile="~/student/MasterPage.master" AutoEventWireup="true" CodeFile="frmstudet.aspx.cs" Inherits="student_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="login-area">
          <div class="user-img">
              <asp:Image ID="Image1" runat="server" Height="203px" Width="167px" />
          </div>
          <section class="user-info-div">
          <div class="user-div"> <label class="label-title">Name </label> <label class="label-field">
              <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></label>    <div class="clearfix"></div></div>
          <div class="user-div"> <label class="label-title">Student of </label> <label class="label-field">
              <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> </label>    <div class="clearfix"></div></div>
         <div class="user-div"> <label class="label-title">Roll No. </label> <label class="label-field">
             <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></label>    <div class="clearfix"></div></div>
          <div class="user-div"> <label class="label-title">Training From </label> <label class="label-field">
              <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label> </label>    <div class="clearfix"></div></div>
           <div class="user-div"> <label class="label-title">To </label> <label class="label-field">
               <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label> </label>    <div class="clearfix"></div></div>
          
      <asp:Button ID="Button1" runat="server" Text="Next"  CssClass ="login-btn" OnClick="Button1_Click"/>
          
            <div class="clearfix"></div>
          </section>
          <div class="clearfix"></div>
        </section>
</asp:Content>

