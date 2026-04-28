<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageAdmin.aspx.cs" Inherits="welcomeCanada.PageAdmin" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Admin</title>
</head>

<body>

<form runat="server">

    <h2> Administration</h2>

    <h3>Ajouter un guide</h3>
    <asp:TextBox ID="txtGuide" runat="server" />
    <asp:Button ID="btnAddGuide" runat="server" Text="Ajouter" OnClick="btnAddGuide_Click" />

    <hr />

    <h3>Utilisateurs</h3>

    <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="true" />

    <br />

    <asp:TextBox ID="txtUserId" runat="server" Placeholder="ID utilisateur" />
    <asp:Button ID="btnDeleteUser" runat="server" Text="Supprimer" OnClick="btnDeleteUser_Click" />

</form>

</body>
</html>