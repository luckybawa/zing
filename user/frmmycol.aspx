<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmmycol.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>My Lesson Collections</h3>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Create Lesson Collection</asp:LinkButton>
        &nbsp;</p>
   
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="949px" DataKeyNames="lescolcod,lescolpubsts" OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table style="width: 100%">
                            <tr>
                                <td rowspan="6" style="width: 243px">
                <img src="../lescol/<%#Eval("lescolcod") %><%#Eval("lescolpic") %>" width="180px"  height="180px" border="1" />

                                </td>
                                <td>
                        <h3><%#Eval("lescoltit") %></h3>
                                </td>
                            </tr>
                            <tr>
                                <td>
                           Created Date :<%#Eval("lescoldat","{0:d}") %></td>
                            </tr>
                            <tr>
                                <td>
                            Cost :<%#Eval("lescolcst") %></td>
                            </tr>
                            <tr>
                                <td>
                            Category :<%#getcat(Convert.ToInt32(Eval("lescolcatcod"))) %></td>
                            </tr>
                            <tr>
                                <td> <%#Eval("lescoldsc") %></td>
                            </tr>
                            <tr>
                                <td>
                            <asp:LinkButton ID="lk1" runat="server" CommandName="Edit"
                                text="Add Lessons" />
                                    &nbsp;&nbsp;
                            <asp:LinkButton ID="lk2" runat="server" CommandName="Delete" />
                               &nbsp;&nbsp;
                            <asp:LinkButton ID="lk3" runat ="server" CommandName="Update"
                                Text="Discussion Board" />
                                     &nbsp;&nbsp;
                            <asp:LinkButton ID="lk4" runat ="server" CommandName="Select"
                                Text="Students Enrolled" />
                                      </td>
                            </tr>
                            
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
   
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="Educom.clslescol">
            <SelectParameters>
                <asp:SessionParameter Name="usrcod" SessionField="cod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
</asp:Content>

