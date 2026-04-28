<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageGuides.aspx.cs" Inherits="welcomeCanada.PageGuides" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Guides</title>

    <style>
        body {
            font-family:'Segoe UI';
            background:#f4f7fb;
            text-align:center;
        }

        .logo { padding:20px; }

        .card {
            display:inline-block;
            width:180px;
            margin:10px;
            padding:20px;
            background:white;
            border-radius:12px;
            box-shadow:0 0 10px #ddd;
            cursor:pointer;
            transition:0.3s;
        }

        .card:hover {
            transform:scale(1.05);
        }
    </style>
</head>

<body>

<form runat="server">

    <div class="logo">
        <img src="images/canada-logo.png" style="width:120px;" />
        <h2>Welcome Canada</h2>
    </div>

    <h1>📘 Guides</h1>

    <asp:Button ID="btnLogement" runat="server" Text="🏠 Logement"
        CssClass="card" OnClick="btnLogement_Click" />

    <asp:Button ID="btnBanque" runat="server" Text="🏦 Banque"
        CssClass="card" OnClick="btnBanque_Click" />

    <asp:Button ID="btnNAS" runat="server" Text="🧾 NAS"
        CssClass="card" OnClick="btnNAS_Click" />

    <asp:Button ID="btnOPUS" runat="server" Text="🚌 OPUS"
        CssClass="card" OnClick="btnOPUS_Click" />

</form>

</body>
</html>