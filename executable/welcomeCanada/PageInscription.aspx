<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageInscription.aspx.cs" Inherits="welcomeCanada.PageInscription" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Inscription</title>

    <style>
        body { font-family: Arial; display:flex; justify-content:center; align-items:center; height:100vh; background:#f5f5f5;}
        .container { background:white; padding:30px; border-radius:10px; width:350px; }
        input, select { width:100%; padding:10px; margin:8px 0; }
        .btn { background:#0078D4; color:white; padding:10px; border:none; width:100%; }
        .message { color:red; text-align:center; }
    </style>
</head>

<body>

    <form runat="server">
        <div class="container">

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

            <br /><br />

            <a href="PageConnexion.aspx">Déjà inscrit ? Connexion</a>

        </div>
    </form>

</body>
</html>