<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmlesexr.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Exercise for
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h3>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" CausesValidation="false" runat="server" OnClick="LinkButton1_Click">Create New Exercise</asp:LinkButton>
    </p>
    <asp:Panel ID="Panel2" runat="server" Visible="False">
            <table style="width: 100%">
        <tr>
            <td style="width: 140px">Exercise Title</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="600px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Exercise Title Require" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 140px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" style="height: 22px" />
            </td>
        </tr>
        </table>
    </asp:Panel>
    <table>
        <tr>
            <td colspan="2">
                <asp:Panel ID="Panel1" runat="server" Visible="False" Width="840px">
                    <table style="width: 103%">
                        <tr>
                            <td style="width: 132px">Add Questions</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 132px">Question Description</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Height="59px" TextMode="MultiLine" Width="600px"></asp:TextBox>
                                </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 132px">Order</td>
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
                            <td style="width: 132px">&nbsp;</td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button3" runat="server" Text="Cancel" CausesValidation="False" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="qstcod" Width="725px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting">
                                    <Columns>
                                        <asp:BoundField DataField="qstdsc" HeaderText="Question Description" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                             <asp:LinkButton ID="lk1" runat ="server" CommandName="Select" CausesValidation="false" Text="Add Options" />
                              <asp:ModalPopupExtender ID="lk1_ModalPopupExtender" runat="server" DynamicServicePath="" Enabled="True" TargetControlID="b1" PopupControlID="Panel3">
                              </asp:ModalPopupExtender>
                            <asp:Button ID="b1" runat ="server" style="display:none" />

                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 132px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>


                <asp:Panel ID="Panel3" runat="server" BackColor="#CCCCCC" BorderStyle="Solid" Height="297px" Visible="False" Width="548px">
                    <table style="width: 100%; height: 156px;">
                        <tr>
                            <td colspan="2">
                                <h4>
                                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                </h4>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 173px">Answer Description</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Height="85px" TextMode="MultiLine" Width="422px"></asp:TextBox>
                                </td>
                            <td>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Answer Description Required"></asp:RequiredFieldValidator>

                            </td>
                        </tr>
                        <tr>
                            <td style="width: 173px">Status</td>
                            <td>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 173px">&nbsp;</td>
                            <td>
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Submit" />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button5" runat="server" Text="Cancel" CausesValidation="False" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="optcod" OnRowDeleting="GridView3_RowDeleting" Width="532px">
                                    <Columns>
                                        <asp:BoundField DataField="optdsc" HeaderText="Answer Description" />
                                        <asp:BoundField DataField="optsts" HeaderText="Status" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>


                <br />
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="554px" DataKeyNames="lesexrcod,lesexrtit" OnRowEditing="GridView2_RowEditing" OnRowDeleting="GridView2_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="lesexrtit" HeaderText="Exercise Title" />
                        <asp:BoundField DataField="noq" HeaderText="No. of questions" />
                        <asp:TemplateField>
                            <ItemTemplate>
          <asp:LinkButton ID="lk1" runat ="server" CommandName="Edit"
              Text="View Details" CausesValidation="false" />
        <asp:LinkButton ID="lk2" runat ="server" CommandName="Delete"
              Text="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsplesexr" TypeName="Educom.clslesexr">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="lescod" QueryStringField="lcod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />


            </td>
        </tr>
    </table>
</asp:Content>

