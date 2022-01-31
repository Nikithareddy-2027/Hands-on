<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TutorialApplication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Register</h1>
            <hr />
            <table>
                <tr>
                    <td>Id</td><td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>          
                </tr>
                <tr>
                    <td>Firstname</td><td>
                        <asp:TextBox ID="txtfname" runat="server"></asp:TextBox></td>          
                </tr>
                <tr>
                    <td>Lastname</td><td>
                        <asp:TextBox ID="txtlname" runat="server"></asp:TextBox> </td>          
                </tr>
                <tr>
                    <td>Email</td><td>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>  
                </tr>
                <tr>
                    <td>Mobile</td><td>
                        <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox> </td>     
                </tr>
                <tr>
                    <td>Password</td><td>
                        <asp:TextBox ID="txtpsw" TextMode ="Password" runat="server"></asp:TextBox> </td>                 
                </tr>
                 <tr><td></td><td>
                     <asp:Button ID="txtRegister" runat="server" Text="Register" OnClick="txtRegister_Click" />
                     <asp:Button ID="txtReset" runat="server" Text="reset" /></td></tr>
                </table>
            <div>
                <asp:Label Text ="" Id ="lblResult" runat ="server" />
            </div>
            <div>
                <h2>User Details</h2>
                <hr />
                <asp:GridView ID="gvUserInfo" runat="server"></asp:GridView>
            </div>

        </div>
    </form>
</body>
</html>
