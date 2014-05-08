<%@ Page Language="VB" AutoEventWireup="false" CodeFile="postbackdefault.aspx.vb" Inherits="_Default" culture="auto:en-US" UIculture="auto"%>

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
            <h3><asp:Label ID="lb_header2" runat="server"  text="Software design and development" meta:resourcekey="lb_header2" /></h3>
            </center>

        

    <div id="content">
        

        <div id="leftside">
            <center>
                <asp:Label ID="Label1" runat="server" Text="Select your language"></asp:Label>
                <br />
                <br />
                
            <asp:DropDownList ID="language1" runat="server" AutoPostBack="true" Width="108px" Height="22px">
                
                
                <asp:ListItem Value="en">English</asp:ListItem>
                <asp:ListItem Value="ar">Arabic</asp:ListItem>
                <asp:ListItem Value="zh">Chinese</asp:ListItem>
                <asp:ListItem Value="es">Spanish</asp:ListItem>
              

            </asp:DropDownList>
            </center>
        </div>


        <div id="rightside">


            




            <asp:Label ID="Label6" runat="server" Text="Hello" meta:resourcekey="Label6"></asp:Label>
            <asp:Label ID="Label7" runat="server" ></asp:Label>
            <asp:Label ID="Label8" runat="server" ></asp:Label>

            ,<br />
            <br />

            <asp:Label ID="Label9" runat="server" Text="I hope you have a great day when you graduate on" meta:resourcekey="Label9" />
            <asp:Label ID="Label10" runat="server" ></asp:Label> &nbsp;!<br />

            <br />

            <asp:Label ID="Label11" runat="server" Text="I wish you well in your career after graduation. I hope you earn" meta:resourcekey="Label11" />
           
            <asp:Label ID="Label12" runat="server" ></asp:Label>
            
            <asp:Label ID="Label13" runat="server" Text="as a salary in your first job !" meta:resourcekey="Label13" />
            <br />
            <br />

            <asp:Label ID="Label14" runat="server" Text="Please visit me on" meta:resourcekey="Label14" />
            
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server">Github</asp:HyperLink>.
            <br />
            <br />
            <br />



        </div>


    </div>
        
    </form>


</body>
</html>
