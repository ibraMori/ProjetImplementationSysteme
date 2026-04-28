<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageConnexion.aspx.cs" Inherits="welcomeCanada.PageConnexion" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Connexion</title>

    <style>
        body {
            font-family: Arial;
            background: #f2f2f2;
            height: 100vh;
            margin: 0;
        }

        /* LOGO TOP LEFT */
        .logo {
            position: absolute;
            top: 15px;
            left: 20px;
            display: flex;
            align-items: center;
            gap: 10px;
        }

        .logo img {
            width: 60px;
            height: 60px;
            border-radius: 10px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.2);
        }

        .logo span {
            font-size: 18px;
            font-weight: bold;
            color: #1a3d6f;
        }

        /* CENTRAGE BOX */
        .container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .box {
            background: white;
            padding: 30px;
            border-radius: 10px;
            width: 320px;
            box-shadow: 0 0 10px #ccc;
            text-align: center;
        }

        input {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
        }

        .btn {
            width: 100%;
            padding: 10px;
            background: #0078D4;
            color: white;
            border: none;
            cursor: pointer;
        }

        .btn:hover {
            background: #005a9e;
        }

        .error {
            color: red;
        }

        a {
            display: block;
            margin-top: 10px;
            text-decoration: none;
            color: #0078D4;
        }
    </style>

</head>

<body>

<!-- LOGO -->
<div class="logo">
    <img src="images/canada-logo.png" />
    <span>Welcome Canada</span>
</div>

<form id="form1" runat="server">

    <div class="container">
        <div class="box">

            <h2>Connexion</h2>

            <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email"></asp:TextBox>

            <asp:TextBox ID="txtMotDePasse" runat="server" TextMode="Password" Placeholder="Mot de passe"></asp:TextBox>

            <asp:Label ID="lblMessage" runat="server" CssClass="error"></asp:Label>

            <asp:Button ID="btnConnexion" runat="server"
                Text="Se connecter"
                CssClass="btn"
                OnClick="btnConnexion_Click" />

            <a href="PageInscription.aspx">Créer un compte</a>
            <a href="PageAdminLogin.aspx">Espace Admin</a>

        </div>
    </div>

</form>

</body>
</html>