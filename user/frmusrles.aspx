<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage2.master" AutoEventWireup="true" CodeFile="frmusrles.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td>
                <h3>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </h3>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
        <embed src=<%=Session["fn"]%> height="300px" />
            </td>
        </tr>
        <tr>
            <td>
                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lesattcod,lesattfil" DataSourceID="ObjectDataSource1" Width="710px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="119px">
                    <Columns>
                        <asp:BoundField DataField="lesattnam" HeaderText="Attachment Name" SortExpression="lesattnam" />
                        <asp:TemplateField>
                            <ItemTemplate>
            <asp:LinkButton ID="lk1" CommandName="Select" Text ="Download Attachment" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
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
        <tr>
            <td>
                   <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Width="702px" DataKeyNames="lesexrcod,lesexrtit" OnRowEditing="GridView2_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="lesexrtit" HeaderText="Exercise Title" />
                        <asp:BoundField DataField="noq" HeaderText="No. of questions" />
                        <asp:TemplateField>
                            <ItemTemplate>
          <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit"
              Text="View Details" />
        <asp:Button ID="b1" runat ="server" Style="display:none" />
         <asp:ModalPopupExtender ID="lk1_ModalPopupExtender" runat="server" 
             DynamicServicePath="" Enabled="True" TargetControlID="b1" PopupControlID="Panel1">
         </asp:ModalPopupExtender>
        
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dsplesexr" TypeName="Educom.clslesexr">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="lescod" QueryStringField="lcod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                   <asp:Panel ID="Panel1" runat="server" BackColor="#DDDDDD" BorderStyle="Solid" Width="655px" Height="301px">
                       <h4>
                           <asp:Label ID="Label3" runat="server"></asp:Label>
                       </h4>
                       <asp:GridView ID="GridView3" runat="server" Width="636px" AutoGenerateColumns="False" ShowHeader="False">
                           <Columns>
                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <table style="width: 100%">
                                           <tr>
                                               <td colspan="2">
                    Q. <%#Eval("qstdsc") %>
                                               </td>
                                           </tr>
                                           <tr>
                                               <td style="width: 171px">&nbsp;</td>
                                               <td>
                   <asp:RadioButtonList ID="r1" runat="server" DataSource=<%#getdata(Convert.ToInt32(Eval("qstcod"))) %> RepeatDirection="Vertical" DataTextField="optdsc">

                   </asp:RadioButtonList>
                                               </td>
                                           </tr>
                                       </table>
                                   </ItemTemplate>
                               </asp:TemplateField>
                           </Columns>
                       </asp:GridView>
                   </asp:Panel>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

