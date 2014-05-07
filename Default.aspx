<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <title></title>

    <link rel="stylesheet" type="text/css" href="./StyleSheet.css" />

</head>
<body>
    <form id="form1" runat="server">


        <center>
        <h1><asp:Label ID="lb_header1" runat="server"  text="Welcome to 6K:183" meta:resourcekey="lb_header1" /></h1>
            <h3>Software Design and Development</h3>
            </center>


    <div id="content">
        

        <div id="leftside">
            <center>
            <asp:DropDownList ID="language1" runat="server" AutoPostBack="true" Width="108px" Height="22px">
                
                <asp:ListItem Value="ar">Arabic</asp:ListItem>
                <asp:ListItem Value="zh">Chinese</asp:ListItem>
                <asp:ListItem Value="en">English</asp:ListItem>
                <asp:ListItem Value="es">Spanish</asp:ListItem>
              

            </asp:DropDownList>
            </center>
        </div>


        <div id="rightside">

            My name is:
            <asp:TextBox ID="tb_name" runat="server" Width="111px" CausesValidation="True" Font-Underline="False" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            I am:<asp:RadioButtonList ID="rbl_gender" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>


            <br />
            <br />


            I plan to graduate on:<br />
&nbsp;<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>



            <br />
            When I gradute, I hope to earn&nbsp;<asp:TextBox ID="tb_salary" runat="server" Width="98px"></asp:TextBox>
            .<br />
            <br />
            <asp:Button ID="bt_submit" runat="server" Text="Submit" />
            <br />
        </div>


    </div>
        
    </form>


</body>
</html>
