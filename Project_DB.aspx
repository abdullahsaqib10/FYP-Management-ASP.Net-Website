<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Project_DB.aspx.cs" Inherits="Project_DB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body style="background-color:lightblue">
    <div style = "display:flex; justify-content: center; align-items:center;">
            <img src="fastlogonew.png" height="15%" width="15%" >     
    </div>
    <form id="form1" runat="server">
        
        <div>
            <p class="auto-style1" style="margin-left: 27%; margin-top: 3%">
                <strong style="font-size: 40px; color: black">WELCOME TO THE LOGIN PORTAL</strong></p>
            <p style="margin-left: 42%"><strong style="font-size:20px">
&nbsp;&nbsp;&nbsp; Please Select From Below </strong></p>
        </div>
        <p style="margin-left: 39%">
            &nbsp;</p>
        <p style="margin-left: 39%">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Student" runat="server" Font-Size="Large" BackColor="#0099CB" BorderColor="White" BorderWidth="0px" Font-Bold="True" ForeColor="White" OnClick="Button1_Click" Text="Student" Height="35px" Width="115px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" BackColor="#0099CB" BorderColor="White" BorderWidth="0px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button1_Click1" Text="Faculty" Height="34px" Width="115px" />
        </p>
        <p style="margin-left: 39%">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#0099CC" BorderColor="Black" BorderWidth="0px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button2_Click" Text="Comittee" Height="35px" Width="115px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" BackColor="#0099CC" BorderColor="Black" BorderWidth="0px" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button3_Click" Text="Panel" Height="35px" Width="115px" />
            &nbsp;
        </p>
    </form>
</body>
</html>
