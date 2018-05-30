<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmstu.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Students Enrolled</h3>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" RepeatColumns="5" RepeatDirection="Horizontal" Width="732px">
    <ItemTemplate>
        <center>
    <img src="../prfpics/<%#Eval("pic") %>" height ="120px" width ="120px" />
            <br />
            <b><%#Eval("nam") %></b><br />
            <%#Eval("usreml") %><br />
            <%#Eval("prfdsc") %>
        </center>
    </ItemTemplate>
    </asp:DataList>
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dspstu" TypeName="Educom.clsenr">
        <SelectParameters>
            <asp:QueryStringParameter Name="lccod" QueryStringField="ccod" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

