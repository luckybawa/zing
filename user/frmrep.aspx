<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmrep.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Discussion Board<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h3>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="717px" DataKeyNames="discod,disrep" OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing">
            <Columns>
                <asp:TemplateField HeaderText="Recent Queries">
                    <ItemTemplate>
                        <table style="width: 100%">
                            <tr>
                                <td>&nbsp;</td>
           <td align="right">Posted Date:<%#Eval("disdat","{0:d}") %></td>
                            </tr>
                            <tr>
                                <td colspan="2">
            <b><%#Eval("distit") %></b>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <%#Eval("disdsc") %>
                                </td>
                                
                            </tr>
                            <tr>
                                <td colspan ="2">
            <i><%#Eval("disrep") %></i>
                <asp:Button ID="b1" runat ="server" style="display:none" />
         <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit" Text="Post Reply" />

         <asp:ModalPopupExtender ID="lk1_ModalPopupExtender" runat="server" 
             DynamicServicePath="" Enabled="True" TargetControlID="b1" PopupControlID="Panel1">
         </asp:ModalPopupExtender>

                                </td>
                             
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
    <td align="right">Posted By:<%#Eval("usreml") %><br /></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dspdis" TypeName="Educom.clsdis">
            <SelectParameters>
                <asp:QueryStringParameter Name="lccod" QueryStringField="ccod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <asp:Panel ID="Panel1" runat="server" BackColor="#E0E0E0" BorderColor="Red" BorderStyle="Solid" Height="280px" Width="562px">
        <table style="width: 100%">
            <tr>
                <td colspan="2">
                    <h4>Reply Query</h4>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server" Height="179px" TextMode="MultiLine" Width="537px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 119px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" CausesValidation="False" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
    </p>
</asp:Content>

