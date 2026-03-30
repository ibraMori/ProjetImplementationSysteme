<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="welcomeCanada.Home" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Accueil</title>

    <style>
        body { font-family: Arial; text-align:center; margin-top:50px; }
        .btn { padding:10px 20px; margin:5px; background:#0078D4; color:white; border:none; border-radius:5px; cursor:pointer; }
        .btn:hover { background:#005a9e; }
    </style>
</head>

<body>

    <h2>Bienvenue sur Welcome Canada</h2>

    <form runat="server">

        <asp:Label ID="lblBienvenue" runat="server"></asp:Label>

        <br /><br />

        <asp:Button ID="BtnLogement" runat="server"
            Text="Chercher un logement"
            CssClass="btn"
            OnClick="BtnLogement_Click" />

        <asp:Button ID="btnLogout" runat="server"
            Text="Déconnexion"
            CssClass="btn"
            OnClick="BtnLogout_Click" />

    </form>

</body>
</html>