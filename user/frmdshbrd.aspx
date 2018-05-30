<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage2.master" AutoEventWireup="true" CodeFile="frmdshbrd.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 100%">
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td rowspan="6" valign ="top" width="25%">
                <asp:Image ID="Image1" runat="server" Height="151px" Width="191px" />
                <br />
                <table align="center">
                    <tr>
                        <td>
                            <h4 align="center">Teacher Profile</h4>
                        </td>
                    </tr>
                    <tr>
                        <td align ="center">
                            <asp:Image ID="Image2" runat="server" Height="151px" Width="191px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <h5>
                                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            </h5>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
            </td>
            <td>Posted Date</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Category</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Cost</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Users Enrolled</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
           
            <td colspan="2" valign="top">Sections<br />
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td colspan="2" valign="top">Description<br />
                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td colspan="2">
              
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="988px">
                    <Columns>
                        <asp:BoundField DataField="lestit" HeaderText="Lesson Title" SortExpression="lestit" />
                        <asp:BoundField DataField="lesdsc" HeaderText="Description" SortExpression="lesdsc" />
                        <asp:BoundField DataField="lestim" HeaderText="Duration" SortExpression="lestim" />
                        <asp:TemplateField>
                            <ItemTemplate>
                <a href="frmusrles.aspx?lcod=<%#Eval("lescod") %>">
                    Lesson Details
                </a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="Educom.clsles">
                    <SelectParameters>
                        <asp:SessionParameter Name="colcod" SessionField="colcod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
              
            </td>
        </tr>
    </table>
</asp:Content>

