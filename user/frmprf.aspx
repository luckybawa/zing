<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmprf.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>My Profile</h3>
    <p>
        &nbsp;</p>
    <table style="width: 100%">
        <tr>
            <td style="width: 125px">First Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="500px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter First Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 125px">Last Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="500px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Last Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 125px" valign="top">About Me</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="164px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter About Me"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 125px">Upload Picture</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 125px">&nbsp;</td>
            <td>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>

