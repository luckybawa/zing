<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="inner">
    <h3>Login</h3>
    <p>
        &nbsp;</p>
    <table style="width: 100%">
        <tr>
            <td style="width: 108px; height: 22px">Email</td>
            <td style="height: 22px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 108px; height: 22px">Password</td>
            <td style="height: 22px">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 108px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 108px">&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 108px">&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="frmreg.aspx">Not Registered Yet?</asp:HyperLink>
            </td>
        </tr>
    </table>

        </div>
</asp:Content>

