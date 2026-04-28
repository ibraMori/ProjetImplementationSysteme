<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageAdminLogin.aspx.cs" Inherits="welcomeCanada.PageAdminLogin" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Admin Login</title>

    <style>
        body {
            font-family: Arial;
            display:flex;
            justify-content:center;
            align-items:center;
            height:100vh;
            background:#1e1e1e;
        }

        .box {
            background:white;
            padding:30px;
            border-radius:10px;
            width:300px;
            text-align:center;
        }

        input {
            width:100%;
            padding:10px;
            margin:10px 0;
        }

        .btn {
            width:100%;
            padding:10px;
            background:#d9534f;
            color:white;
            border:none;
        }

        .error {
            color:red;
        }
    </style>
</head>

<body>

<form runat="server">

    <div class="box">

        <h2>Admin Access</h2>

        <asp:TextBox ID="txtAdminId" runat="server" Placeholder="Admin ID"></asp:TextBox>

        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Mot de passe"></asp:TextBox>

        <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>

        <asp:Button ID="btnLogin" runat="server"
            Text="Connexion"
            CssClass="btn"
            OnClick="btnLogin_Click" />

    </div>

</form>

</body>
</html>