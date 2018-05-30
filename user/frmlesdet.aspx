<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmlesdet.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table style="width: 100%">
        <tr>
            <td colspan="3">
                <h3>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </h3>
            </td>
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
                <asp:Button ID="Button1" runat="server" Text="Enroll" OnClick="Button1_Click" />
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
                <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatColumns="4" RepeatDirection="Horizontal" Width="744px">
                   <HeaderTemplate>
                       <h4 align="center">Teacher's Other Contributions</h4>
                   </HeaderTemplate>
                     <ItemTemplate>
                        <table style="width: 100%" >
                            <tr>
                                <td align ="center">
 <a href="frmlesdet.aspx?lccod=<%#Eval("lescolcod") %>">
     <img src="../lescol/<%#Eval("lescolcod") %><%#Eval("lescolpic") %>"
         height="150px" width ="150px" border="1" />
 </a>
                                </td>           
                            </tr>
                            <tr>
                                <td align ="center">
                                    <%#Eval("catnam") %>
                                </td>
                            </tr>
                            <tr>
                                <td align ="center">
 <a href="frmlesdet.aspx?lccod=<%#Eval("lescolcod") %>">
     <%#Eval("lescoltit") %>
 </a>
                                </td>
                               
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>

</asp:Content>

