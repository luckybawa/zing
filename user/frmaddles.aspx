<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmaddles.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h3>
    <br />
    <table style="width: 100%">
        <tr>
            <td style="width: 111px">Lesson Title</td>
            <td>
                <asp:TextBox ID="txtlestit" runat="server" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtlestit" ErrorMessage="Enter Lesson Tilte"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 111px">Description</td>
            <td>
                <asp:TextBox ID="txtdsc" runat="server" Height="177px" TextMode="MultiLine" Width="849px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtdsc" ErrorMessage="Enter Description"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 111px">Order</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 111px">Time</td>
            <td>
                <asp:TextBox ID="txtlestim" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtlestim" ErrorMessage="Enter Time"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 111px">Upload File</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 111px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" CausesValidation="false" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lescod" DataSourceID="ObjectDataSource1" Width="971px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCancelingEdit="GridView1_RowCancelingEdit" Height="128px" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="lestit" HeaderText="Lesson Title" SortExpression="lestit" />
                        <asp:BoundField DataField="lestim" HeaderText="Time" SortExpression="lestim" />
                        <asp:BoundField DataField="lesord" HeaderText="Order" SortExpression="lesord" />
                        <asp:CommandField ShowDeleteButton="True" />
                        <asp:TemplateField>
            <ItemTemplate>
 <asp:LinkButton ID="lk1" runat="server" CommandName="Select"
     text="Add Attachments" CausesValidation="false" />
                &nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="lk2" runat ="server" CommandName="Cancel"
    text="Add Exercises" CausesValidation="false" />
            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="Educom.clsles">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="colcod" QueryStringField="ccod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

