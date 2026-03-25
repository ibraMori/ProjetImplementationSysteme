<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageConexion.aspx.cs" Inherits="welcomeCanada.pageConexion" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Connexion Welcome Canada</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px; font-family: Arial;">

            <h2>Connexion</h2>

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe :"></asp:Label>
            <asp:TextBox ID="txtMotDePasse" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnConnexion" runat="server" Text="Se connecter" OnClick="btnConnexion_Click" />
            <br /><br />

            <asp:Button ID="btnInscrire" runat="server" Text="S'inscrire" OnClick="btnInscrire_Click" />

        </div>
    </form>
</body>
</html>