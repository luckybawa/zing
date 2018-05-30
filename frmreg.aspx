<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmreg.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div class="inner">
     <h3>Register Here<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</h3>
<p>
    &nbsp;</p>
<table style="width: 100%">
    <tr>
        <td style="width: 136px; height: 22px">Email</td>
        <td style="height: 22px; width: 174px">
            <asp:TextBox ID="txteml" runat="server" Width="180px"></asp:TextBox>
        </td>
        <td style="height: 22px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txteml" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 136px; height: 22px">Password</td>
        <td style="height: 22px; width: 174px">
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <asp:PasswordStrength ID="txtpwd_PasswordStrength" runat="server" Enabled="True" TargetControlID="txtpwd">
            </asp:PasswordStrength>
        </td>
        <td style="height: 22px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd" ErrorMessage="Password Required">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 136px; height: 22px">Confirm Password</td>
        <td style="height: 22px; width: 174px">
            <asp:TextBox ID="txtconpwd" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
        </td>
        <td style="height: 22px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtconpwd" ErrorMessage="Confirm Password Required">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtconpwd" ErrorMessage="Password &amp; Confirm Password must match">*</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 136px; height: 22px">&nbsp;</td>
        <td style="height: 22px; width: 174px">
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cancel" CausesValidation="False" OnClick="Button2_Click" />
        </td>
        <td style="height: 22px">&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 22px" colspan="3">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" style="height: 22px">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </td>
    </tr>
</table>

</div>
</asp:Content>

