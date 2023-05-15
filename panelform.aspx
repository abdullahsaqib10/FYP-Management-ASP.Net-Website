<%@ Page Language="C#" AutoEventWireup="true" CodeFile="panelform.aspx.cs" Inherits="panelform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #FF9999; color: #CC3300; height: 2199px;">
            PANEL INTERFACE&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#CC3300" ForeColor="White" OnClick="Button2_Click" Text="Log out" />
            <br />
            ___________________________________________________________________________________________________________________<br />
            <br />
            VIEWING FYP INFORMATION<br />
            <br />
            Enter your Panel ID to view your FYP information&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#CC3300" ForeColor="White" OnClick="Button1_Click" Text="Enter" Width="95px" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            ___________________________________________________________________________________________________________________<br />
            <br />
            <br />
            FYP EVALUATION<br />
            <br />
            <br />
            Enter group ID for Evaluation&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            1. FYP Poster<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton4" runat="server" OnCheckedChanged="RadioButton4_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton5" runat="server" OnCheckedChanged="RadioButton5_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton6" runat="server" OnCheckedChanged="RadioButton6_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton7" runat="server" OnCheckedChanged="RadioButton7_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton8" runat="server" OnCheckedChanged="RadioButton8_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton9" runat="server" OnCheckedChanged="RadioButton9_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton10" runat="server" OnCheckedChanged="RadioButton10_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton11" runat="server" OnCheckedChanged="RadioButton11_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            2. Iteration Definition, FYP Plan, Work Breakdown<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton12" runat="server" OnCheckedChanged="RadioButton12_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton13" runat="server" OnCheckedChanged="RadioButton13_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton14" runat="server" OnCheckedChanged="RadioButton14_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton15" runat="server" OnCheckedChanged="RadioButton15_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton16" runat="server" OnCheckedChanged="RadioButton16_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton17" runat="server" OnCheckedChanged="RadioButton17_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton18" runat="server" OnCheckedChanged="RadioButton18_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton19" runat="server" OnCheckedChanged="RadioButton19_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton20" runat="server" OnCheckedChanged="RadioButton20_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton21" runat="server" OnCheckedChanged="RadioButton21_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton22" runat="server" OnCheckedChanged="RadioButton22_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            3. Work completed for the iteration(s) including design &amp; implementation<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton23" runat="server" OnCheckedChanged="RadioButton23_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton24" runat="server" OnCheckedChanged="RadioButton24_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton25" runat="server" OnCheckedChanged="RadioButton25_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton26" runat="server" OnCheckedChanged="RadioButton26_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton27" runat="server" OnCheckedChanged="RadioButton27_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton28" runat="server" OnCheckedChanged="RadioButton28_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton29" runat="server" OnCheckedChanged="RadioButton29_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton30" runat="server" OnCheckedChanged="RadioButton30_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton31" runat="server" OnCheckedChanged="RadioButton31_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton32" runat="server" OnCheckedChanged="RadioButton32_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton33" runat="server" OnCheckedChanged="RadioButton33_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            4. Slide Design and Content Quality<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton34" runat="server" OnCheckedChanged="RadioButton34_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton35" runat="server" OnCheckedChanged="RadioButton35_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton36" runat="server" OnCheckedChanged="RadioButton36_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton37" runat="server" OnCheckedChanged="RadioButton37_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton38" runat="server" OnCheckedChanged="RadioButton38_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton39" runat="server" OnCheckedChanged="RadioButton39_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton40" runat="server" OnCheckedChanged="RadioButton40_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton41" runat="server" OnCheckedChanged="RadioButton41_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton42" runat="server" OnCheckedChanged="RadioButton42_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton43" runat="server" OnCheckedChanged="RadioButton43_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton44" runat="server" OnCheckedChanged="RadioButton44_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            5. Style (Delivery, Confidence, Clarity)<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton45" runat="server" OnCheckedChanged="RadioButton45_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton46" runat="server" OnCheckedChanged="RadioButton46_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton47" runat="server" OnCheckedChanged="RadioButton47_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton48" runat="server" OnCheckedChanged="RadioButton48_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton49" runat="server" OnCheckedChanged="RadioButton49_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton50" runat="server" OnCheckedChanged="RadioButton50_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton51" runat="server" OnCheckedChanged="RadioButton51_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton52" runat="server" OnCheckedChanged="RadioButton52_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton53" runat="server" OnCheckedChanged="RadioButton53_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton54" runat="server" OnCheckedChanged="RadioButton54_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton55" runat="server" OnCheckedChanged="RadioButton55_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            6. Clarity of Project Scope<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton56" runat="server" OnCheckedChanged="RadioButton56_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton57" runat="server" OnCheckedChanged="RadioButton57_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton58" runat="server" OnCheckedChanged="RadioButton58_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton59" runat="server" OnCheckedChanged="RadioButton59_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton60" runat="server" OnCheckedChanged="RadioButton60_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton61" runat="server" OnCheckedChanged="RadioButton61_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton62" runat="server" OnCheckedChanged="RadioButton62_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton63" runat="server" OnCheckedChanged="RadioButton63_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton64" runat="server" OnCheckedChanged="RadioButton64_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton65" runat="server" OnCheckedChanged="RadioButton65_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton66" runat="server" OnCheckedChanged="RadioButton66_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            7. Definition of Project Features<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton67" runat="server" OnCheckedChanged="RadioButton67_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton68" runat="server" OnCheckedChanged="RadioButton68_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton69" runat="server" OnCheckedChanged="RadioButton69_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton70" runat="server" OnCheckedChanged="RadioButton70_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton71" runat="server" OnCheckedChanged="RadioButton71_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton72" runat="server" OnCheckedChanged="RadioButton72_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton73" runat="server" OnCheckedChanged="RadioButton73_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton74" runat="server" OnCheckedChanged="RadioButton74_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton75" runat="server" OnCheckedChanged="RadioButton75_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton76" runat="server" OnCheckedChanged="RadioButton76_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton77" runat="server" OnCheckedChanged="RadioButton77_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            8. Team Dynamics (Coordination among team members)<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton78" runat="server" OnCheckedChanged="RadioButton78_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton79" runat="server" OnCheckedChanged="RadioButton79_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton80" runat="server" OnCheckedChanged="RadioButton80_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton81" runat="server" OnCheckedChanged="RadioButton81_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton82" runat="server" OnCheckedChanged="RadioButton82_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton83" runat="server" OnCheckedChanged="RadioButton83_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton84" runat="server" OnCheckedChanged="RadioButton84_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton85" runat="server" OnCheckedChanged="RadioButton85_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton86" runat="server" OnCheckedChanged="RadioButton86_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton87" runat="server" OnCheckedChanged="RadioButton87_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton88" runat="server" OnCheckedChanged="RadioButton88_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            9. Timing of Presentation<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton89" runat="server" OnCheckedChanged="RadioButton89_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton90" runat="server" OnCheckedChanged="RadioButton90_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton91" runat="server" OnCheckedChanged="RadioButton91_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton92" runat="server" OnCheckedChanged="RadioButton92_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton93" runat="server" OnCheckedChanged="RadioButton93_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton94" runat="server" OnCheckedChanged="RadioButton94_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton95" runat="server" OnCheckedChanged="RadioButton95_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton96" runat="server" OnCheckedChanged="RadioButton96_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton97" runat="server" OnCheckedChanged="RadioButton97_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton98" runat="server" OnCheckedChanged="RadioButton98_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton99" runat="server" OnCheckedChanged="RadioButton99_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            10. Implementation Work Complete<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton100" runat="server" OnCheckedChanged="RadioButton100_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton101" runat="server" OnCheckedChanged="RadioButton101_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton102" runat="server" OnCheckedChanged="RadioButton102_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton103" runat="server" OnCheckedChanged="RadioButton103_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton104" runat="server" OnCheckedChanged="RadioButton104_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton105" runat="server" OnCheckedChanged="RadioButton105_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton106" runat="server" OnCheckedChanged="RadioButton106_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton107" runat="server" OnCheckedChanged="RadioButton107_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton108" runat="server" OnCheckedChanged="RadioButton108_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton109" runat="server" OnCheckedChanged="RadioButton109_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton110" runat="server" OnCheckedChanged="RadioButton110_CheckedChanged" Text="  10" />
&nbsp; Full<br />
            <br />
            11. Overall Work Quality and Impression<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton111" runat="server" OnCheckedChanged="RadioButton111_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton112" runat="server" OnCheckedChanged="RadioButton112_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton113" runat="server" OnCheckedChanged="RadioButton113_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton114" runat="server" OnCheckedChanged="RadioButton114_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton115" runat="server" OnCheckedChanged="RadioButton115_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton116" runat="server" OnCheckedChanged="RadioButton116_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton117" runat="server" OnCheckedChanged="RadioButton117_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton118" runat="server" OnCheckedChanged="RadioButton118_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton119" runat="server" OnCheckedChanged="RadioButton119_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton120" runat="server" OnCheckedChanged="RadioButton120_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton121" runat="server" OnCheckedChanged="RadioButton121_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            12. Code Quantity<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton122" runat="server" OnCheckedChanged="RadioButton122_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton123" runat="server" OnCheckedChanged="RadioButton123_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton124" runat="server" OnCheckedChanged="RadioButton124_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton125" runat="server" OnCheckedChanged="RadioButton125_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton126" runat="server" OnCheckedChanged="RadioButton126_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton127" runat="server" OnCheckedChanged="RadioButton127_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton128" runat="server" OnCheckedChanged="RadioButton128_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton129" runat="server" OnCheckedChanged="RadioButton129_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton130" runat="server" OnCheckedChanged="RadioButton130_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton131" runat="server" OnCheckedChanged="RadioButton131_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton132" runat="server" OnCheckedChanged="RadioButton132_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            13. Level of Code Integration<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton133" runat="server" OnCheckedChanged="RadioButton133_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton134" runat="server" OnCheckedChanged="RadioButton134_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton135" runat="server" OnCheckedChanged="RadioButton135_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton136" runat="server" OnCheckedChanged="RadioButton136_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton137" runat="server" OnCheckedChanged="RadioButton137_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton138" runat="server" OnCheckedChanged="RadioButton138_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton139" runat="server" OnCheckedChanged="RadioButton139_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton140" runat="server" OnCheckedChanged="RadioButton140_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton141" runat="server" OnCheckedChanged="RadioButton141_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton142" runat="server" OnCheckedChanged="RadioButton142_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton143" runat="server" OnCheckedChanged="RadioButton143_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            14. Class Diagram/DFD (provided in the report) correctly maps to the Code Implemented<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton144" runat="server" OnCheckedChanged="RadioButton144_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton145" runat="server" OnCheckedChanged="RadioButton145_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton146" runat="server" OnCheckedChanged="RadioButton146_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton147" runat="server" OnCheckedChanged="RadioButton147_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton148" runat="server" OnCheckedChanged="RadioButton148_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton149" runat="server" OnCheckedChanged="RadioButton149_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton150" runat="server" OnCheckedChanged="RadioButton150_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton151" runat="server" OnCheckedChanged="RadioButton151_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton152" runat="server" OnCheckedChanged="RadioButton152_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton153" runat="server" OnCheckedChanged="RadioButton153_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton154" runat="server" OnCheckedChanged="RadioButton154_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full<br />
            <br />
            15. Handling of Questions<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min
            <asp:RadioButton ID="RadioButton155" runat="server" CausesValidation="True" OnCheckedChanged="RadioButton155_CheckedChanged" Text="0" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton156" runat="server" OnCheckedChanged="RadioButton156_CheckedChanged" Text="1" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton157" runat="server" OnCheckedChanged="RadioButton157_CheckedChanged" Text="2" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton158" runat="server" OnCheckedChanged="RadioButton158_CheckedChanged" Text="3" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton159" runat="server" OnCheckedChanged="RadioButton159_CheckedChanged" Text="4" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton160" runat="server" OnCheckedChanged="RadioButton160_CheckedChanged" Text="5" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton161" runat="server" OnCheckedChanged="RadioButton161_CheckedChanged" Text="6" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton162" runat="server" OnCheckedChanged="RadioButton162_CheckedChanged" Text="7" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton163" runat="server" OnCheckedChanged="RadioButton163_CheckedChanged" Text="8" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton164" runat="server" OnCheckedChanged="RadioButton164_CheckedChanged" Text="9" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton165" runat="server" OnCheckedChanged="RadioButton165_CheckedChanged" Text="10" />
&nbsp;&nbsp; Full&nbsp;
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" BackColor="#CC3300" ForeColor="White" OnClick="Button3_Click" Text="Submit Evaluation" Width="125px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" BackColor="#CC3300" ForeColor="White" OnClick="Button4_Click" Text="Press to view Marks and Grade" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
