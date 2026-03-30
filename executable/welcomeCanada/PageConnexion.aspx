<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageConnexion.aspx.cs" Inherits="welcomeCanada.PageConnexion" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Connexion</title>

    <style>
        body { font-family: Arial; display:flex; justify-content:center; align-items:center; height:100vh; background:#f5f5f5;}
        .container { background:white; padding:30px; border-radius:10px; width:350px; box-shadow:0 0 10px rgba(0,0,0,0.2);}
        input { width:100%; padding:10px; margin:8px 0; }
        .btn { background:#0078D4; color:white; padding:10px; border:none; width:100%; margin-top:10px; }
        .message { color:red; text-align:center; }
    </style>
</head>

<body>

    <form runat="server">
        <div class="container">

            <h2>Connexion</h2>

            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>

            <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email" />
            <asp:TextBox ID="txtMotDePasse" runat="server" TextMode="Password" Placeholder="Mot de passe" />

            <asp:Button ID="btnConnexion" runat="server"
                Text="Connexion"
                CssClass="btn"
                OnClick="BtnConnexion_Click" />

            <asp:Button ID="btnAllerInscription" runat="server"
                Text="Créer un compte"
                CssClass="btn"
                PostBackUrl="PageInscription.aspx" />

        </div>
    </form>

</body>
</html>