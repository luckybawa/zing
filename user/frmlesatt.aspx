<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmlesatt.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h3>
    <p>
        &nbsp;</p>
    <table style="width: 100%">
        <tr>
            <td style="width: 169px">
                <h4>Upload Attachment</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 169px">Attachment Name</td>
            <td>
                <asp:TextBox ID="txtattnam" runat="server" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtattnam" ErrorMessage="Attachment NameRequired"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 169px">Browse File</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 169px; height: 32px"></td>
            <td style="height: 32px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lesattcod,lesattfil" DataSourceID="ObjectDataSource1" Width="710px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="126px" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="lesattnam" HeaderText="Attachment Name" SortExpression="lesattnam" />
                        <asp:TemplateField>
                            <ItemTemplate>
            <asp:LinkButton ID="lk1" CommandName="Select" CausesValidation="false" Text ="Download Attachment" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="Educom.clslesatt">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="lescod" QueryStringField="lcod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

