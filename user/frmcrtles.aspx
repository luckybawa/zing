<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmcrtles.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Lesson Collection<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h3>
    <p>
        &nbsp;</p>
    <table style="width: 100%">
        <tr>
            <td style="width: 127px">Select Category</td>
            <td style="width: 1041px">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 127px">Collection Title</td>
            <td style="width: 1041px">
                <asp:TextBox ID="TextBox1" runat="server" Width="900px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Collection Title" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 127px">Description</td>
            <td style="width: 1041px">
                <asp:TextBox ID="TextBox2" runat="server" Height="130px" TextMode="MultiLine" Width="965px"></asp:TextBox>
            </td>
            <td>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Description" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td style="width: 127px">Sections</td>
            <td style="width: 1041px">
                <asp:TextBox ID="TextBox4" runat="server" Height="238px" TextMode="MultiLine" Width="962px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 127px">Cost</td>
            <td style="width: 1041px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Cost"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 127px">Picture</td>
            <td style="width: 1041px">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 127px">&nbsp;</td>
            <td style="width: 1041px">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Do you wish to publish this collection?" />
            </td>
        </tr>
        <tr>
            <td style="width: 127px">&nbsp;</td>
            <td style="width: 1041px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td style="width: 127px">&nbsp;</td>
            <td style="width: 1041px">
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="Educom.clscat"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

