<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmcat.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Categories</h3>
<p>
    &nbsp;</p>
<table style="width: 100%">
    <tr>
        <td style="width: 108px; height: 23px">Category</td>
        <td style="height: 23px; width: 138px">
            <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
        </td>
        <td style="height: 23px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Entry Compulsory"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 108px; height: 23px">Picture</td>
        <td style="height: 23px; width: 138px">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 108px">&nbsp;</td>
        <td colspan="2">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cancel" CausesValidation="False" OnClick="Button2_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="212px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="catcod" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:TemplateField>
            <ItemTemplate>
                <center>
    <img src="../catpics/<%#Eval("catcod") %><%#Eval("catpic") %>"
        border="2" height ="150px" width ="150px" /><br />
                    <%#Eval("catnam") %><br />
    <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit"
        Text="Edit" CausesValidation ="false"  />
                    &nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lk2" runat ="server" CommandName="Delete"
        Text="Delete"  CausesValidation ="false" />
                </center>

            </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="Educom.clscat"></asp:ObjectDataSource>
        </td>
    </tr>
</table>
</asp:Content>

