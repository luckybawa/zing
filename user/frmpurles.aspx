<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmpurles.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Enrolled Lessons</h3>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lescolcod" DataSourceID="ObjectDataSource1" Width="946px" Height="162px" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="catnam" HeaderText="Category" />
                <asp:BoundField DataField="lescoltit" HeaderText="Lesson Collection" />
                <asp:BoundField DataField="lescolcst" HeaderText="Cost" />
                <asp:BoundField DataField="enrdat" DataFormatString="{0:d}" HeaderText="Enrollement Date" />
                <asp:TemplateField>
        <ItemTemplate>
    <asp:LinkButton ID="lk1" runat="server" CommandName="Edit"
                                Text="View Details" />
        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsppurles" TypeName="Educom.clsenr">
            <SelectParameters>
                <asp:SessionParameter Name="usrcod" SessionField="cod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
</asp:Content>

