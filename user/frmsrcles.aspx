<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmsrcles.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Search Lesson Collections</h3>
    <p>
        &nbsp;</p>
    <p>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" CellPadding="4" ForeColor="#333333" Height="370px" RepeatColumns="4" RepeatDirection="Horizontal" Width="806px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#E3EAEB" />
            <ItemTemplate>
          <center>
    <img src="../catpics/<%#Eval("catcod")%><%#Eval("catpic")%>"
        border="2" height ="150px" width ="150px" /><br />
    <a href="frmres.aspx?ccod=<%#Eval("catcod") %>">
        <%#Eval("catnam") %>
    </a>
          </center>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="Educom.clscat"></asp:ObjectDataSource>
    </p>
</asp:Content>

