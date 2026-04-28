<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageInscription.aspx.cs" Inherits="welcomeCanada.PageInscription" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Inscription</title>

    <style>

        body {
            font-family: Arial;
            background: #f5f5f5;
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

        /* FORM */
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
            width: 350px;
            box-shadow: 0 0 10px #ccc;
            text-align: center;
        }

        input, select {
            width: 100%;
            padding: 10px;
            margin: 8px 0;
        }

        .btn {
            background: #0078D4;
            color: white;
            padding: 10px;
            border: none;
            width: 100%;
            cursor: pointer;
        }

        .btn:hover {
            background: #005a9e;
        }

        .message {
            color: red;
            text-align: center;
        }

        a {
            display: block;
            margin-top: 10px;
            color: #0078D4;
            text-decoration: none;
        }

    </style>
</head>

<body>

<!-- LOGO -->
<div class="logo">
    <img src="images/canada-logo.png" />
    <span>Welcome Canada</span>
</div>

<form runat="server">

    <div class="container">

        <div class="box">

            <h2>Inscription</h2>

            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>

            <asp:TextBox ID="txtNom" runat="server" Placeholder="Nom" />
            <asp:TextBox ID="txtPrenom" runat="server" Placeholder="Prénom" />
            <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email" />
            <asp:TextBox ID="txtMotDePasse" runat="server" TextMode="Password" Placeholder="Mot de passe" />

            <asp:DropDownList ID="ddlTypeUtilisateur" runat="server">
                <asp:ListItem Text="Etudiant" Value="Etudiant" />
                <asp:ListItem Text="Travailleur" Value="Travailleur" />
            </asp:DropDownList>

            <asp:Button ID="btnInscrire" runat="server"
                Text="S'inscrire"
                CssClass="btn"
                OnClick="BtnInscrire_Click" />

            <a href="PageConnexion.aspx">Déjà inscrit ? Connexion</a>

        </div>

    </div>

</form>

</body>
</html>