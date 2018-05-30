<%@ Page Title="" Language="C#" MasterPageFile="~/student/MasterPage.master" AutoEventWireup="true" CodeFile="regwrk.aspx.cs" Inherits="student_Default" %>

<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
<section class ="login-area">

    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <h3>Input Student Details<asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </h3>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">Name</td>
            <td>
                <asp:TextBox ID="txtstunam" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">College</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>RIEIT , RAILMAJRA ,ROPAR (PB)</asp:ListItem>
                    <asp:ListItem Value="DBEC, MGG, FGS. (PB)">DBEC, MGG, FGS.(PB)</asp:ListItem>
                    <asp:ListItem>GIMET, ASR. (PB)</asp:ListItem>
                    <asp:ListItem>DBIMCS (MCA) MANDIGOBINDGARH</asp:ListItem>
                    <asp:ListItem>CIET, JALVEHRA </asp:ListItem>
                    <asp:ListItem>JSSIET,PATIALA</asp:ListItem>
                    <asp:ListItem>BCET, GURDASPUR</asp:ListItem>
                    <asp:ListItem>NWIET, MOGA</asp:ListItem>
                    <asp:ListItem>LLRIET, MOGA</asp:ListItem>
                    <asp:ListItem>GGS KHARAR</asp:ListItem>
                    <asp:ListItem>RIIMT, MANDIGOBINDGARH</asp:ListItem>
                    <asp:ListItem>SAI, BADHANI</asp:ListItem>
                    <asp:ListItem>RAYAT &amp; BAHRA MOHALI</asp:ListItem>
                    <asp:ListItem>JMIT, RADOUR</asp:ListItem>
                    <asp:ListItem>DAVIET, JALANDHAR</asp:ListItem>
                    <asp:ListItem>RAYAT &amp; BAHRA HSPR.</asp:ListItem>
                    <asp:ListItem>SVIET BANUR</asp:ListItem>
                    <asp:ListItem>IET, BHADDAL</asp:ListItem>
                    <asp:ListItem>PUNJABI UNIVERSITY PATIALA</asp:ListItem>
                    <asp:ListItem>YCOE TALWANDISABO</asp:ListItem>
                    <asp:ListItem>CHITKARA UNIVERSITY PATIALA </asp:ListItem>
                    <asp:ListItem>CHITKARA UNIVERSITY BADDI</asp:ListItem>
                    <asp:ListItem>INDUS UNIVERSITY UNA</asp:ListItem>
                    <asp:ListItem>LPU PHAGWARA</asp:ListItem>
                    <asp:ListItem>PUSSGRC, HOSHIRAPUR</asp:ListItem>
                    <asp:ListItem>HPU UNIVERSITY SHIMLA</asp:ListItem>
                    <asp:ListItem>PCTE LUDHIANA</asp:ListItem>
                    <asp:ListItem>AIMT AMBALA </asp:ListItem>
                    <asp:ListItem>GVIET BANUR</asp:ListItem>
                    <asp:ListItem>BHUTTA COLLEGE OF ANGINEERING</asp:ListItem>
                    <asp:ListItem>UCOE PUNJABI UNIVERSITY</asp:ListItem>
                    <asp:ListItem>GZU HISAR</asp:ListItem>
                    <asp:ListItem>GTBKIET MALAUT </asp:ListItem>
                    <asp:ListItem>GGNIMT LUDHIANA </asp:ListItem>
                    <asp:ListItem>MIMT MALAUT</asp:ListItem>
                    <asp:ListItem>GNDU AMRITSAR </asp:ListItem>
                    <asp:ListItem>KHALSA COLLEGE AMRITSAR </asp:ListItem>
                    <asp:ListItem>CGC LANDRAN</asp:ListItem>
                    <asp:ListItem>PAU LUDHIANA </asp:ListItem>
                    <asp:ListItem>DIET KHARAR </asp:ListItem>
                    <asp:ListItem>SA JAIN COLLEGE AMBALA </asp:ListItem>
                    <asp:ListItem>LCET LUDHIANA </asp:ListItem>
                    <asp:ListItem>CT INSTT JALANDHAR </asp:ListItem>
                    <asp:ListItem>SPCET LALRU</asp:ListItem>
                    <asp:ListItem>DAV AMBALA </asp:ListItem>
                    <asp:ListItem>KHALSA COLLEGE KARNAL </asp:ListItem>
                    <asp:ListItem>ACET AMRITSAR </asp:ListItem>
                    <asp:ListItem>SGHMT PATIALA </asp:ListItem>
                    <asp:ListItem>HPIMS SHIMLA </asp:ListItem>
                    <asp:ListItem>BGIET SANGRUR</asp:ListItem>
                    <asp:ListItem>BBSBEC FATEHGARH SAHIB</asp:ListItem>
                    <asp:ListItem>ARYA BHATTA COLLEGE BARNALA </asp:ListItem>
                    <asp:ListItem>COEM RAMPUR PHULL</asp:ListItem>
                    <asp:ListItem>DOON VALLEY INSTT OF ENGINEERING </asp:ListItem>
                    <asp:ListItem>CDLU SIRSA</asp:ListItem>
                    <asp:ListItem>DCSA KURUKSHETRA</asp:ListItem>
                    <asp:ListItem>APEEJAY INSTT JALANDHAR</asp:ListItem>
                    <asp:ListItem>GRDIET LEHRABAGGA</asp:ListItem>
                    <asp:ListItem>BFCET BATHINDA</asp:ListItem>
                    <asp:ListItem>SAI INSTT AMRITSAR</asp:ListItem>
                    <asp:ListItem>BIS MOGA</asp:ListItem>
                    <asp:ListItem>ALMA INDORA</asp:ListItem>
                    <asp:ListItem>GNDU REGIONSL CAMPUS</asp:ListItem>
                    <asp:ListItem>PCTE LUDHIANA</asp:ListItem>
                    <asp:ListItem>BHSBIET LEHRA GAGA</asp:ListItem>
                    <asp:ListItem>PURCITM MOHALI</asp:ListItem>
                    <asp:ListItem>SBBSIET JALANDHAR</asp:ListItem>
                    <asp:ListItem>HGPI KALA AMB</asp:ListItem>
                    <asp:ListItem>MULLANA AMBALA </asp:ListItem>
                    <asp:ListItem>GJIMT MOHALI</asp:ListItem>
                    <asp:ListItem>DOON VALLEY SIRSA </asp:ListItem>
                    <asp:ListItem>SSIET DERABASSI </asp:ListItem>
                    <asp:ListItem>GNDEC LUDHIANA </asp:ListItem>
                    <asp:ListItem>FCET FZR </asp:ListItem>
                     <asp:ListItem>MDU ROHTAK </asp:ListItem>
                    <asp:ListItem>OTHERS</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox1" runat="server" Visible="False" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">Roll No</td>
            <td>
                <asp:TextBox ID="txtrolno" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">Training Start Date</td>
            <td>
                <asp:TextBox ID="txttrgstrdat" runat="server" Width="200px"></asp:TextBox>
                <%--<asp:CalendarExtender ID="txttrgstrdat_CalendarExtender" runat="server" Enabled="True" TargetControlID="txttrgstrdat">
                </asp:CalendarExtender>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">Training End Date</td>
            <td>
                <asp:TextBox ID="txttrgenddat" runat="server" Width="200px"></asp:TextBox>
               <%-- <asp:CalendarExtender ID="txttrgenddat_CalendarExtender" runat="server" Enabled="True" TargetControlID="txttrgenddat">
                </asp:CalendarExtender>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">Username</td>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#003399"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">Password</td>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#003399"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 610px">Picture</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 610px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#003399"></asp:Label>
            </td>
        </tr>
    </table>

</section>
  
</asp:Content>

