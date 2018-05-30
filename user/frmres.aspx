<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmres.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="752px" OnRowDataBound="GridView1_RowDataBound" DataKeyNames="lescolcod" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <table style="width: 100%">
                        <tr>
      <td rowspan="6" style="width: 180px">
 <img src="../lescol/<%#Eval("lescolcod") %><%#Eval("lescolpic") %>"
     height="120px" width ="120px" border="1" />
      </td>
                            <td><b><%#Eval("lescoltit") %></b></td>
                        </tr>
                        <tr>
                            <td>Posted By :<i><%#Eval("nam") %></i></td>
                        </tr>
                        <tr>
                            <td>Already <%#Eval("nos") %> students enrolled</td>
                        </tr>
                        <tr>
                            <td>Cost :$<%#Eval("lescolcst") %></td>
                        </tr>
                        <tr>
                            <td><%#Eval("dsc") %></td>
                        </tr>
                        <tr>
                            <td align ="right">
                            <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit"
                                Text="View Details" />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="srclescol" TypeName="Educom.clslescol">
        <SelectParameters>
            <asp:QueryStringParameter Name="catcod" QueryStringField="ccod" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

