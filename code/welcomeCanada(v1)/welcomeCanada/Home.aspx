<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="welcomeCanada.Home" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Accueil</title>

    <style>
        body {
            font-family: 'Segoe UI', Arial;
            background: linear-gradient(to right, #eef2f7, #f8fbff);
            margin: 0;
            padding: 30px;
        }

        h1 {
            text-align: center;
            color: #1a3d6f;
            margin-bottom: 30px;
        }

        h2, h3 {
            color: #1a3d6f;
        }

        .container {
            width: 900px;
            margin: auto;
        }

        .card {
            background: white;
            margin: 15px 0;
            padding: 20px;
            border-radius: 12px;
            box-shadow: 0 4px 15px rgba(0,0,0,0.08);
            transition: 0.3s;
        }

        .card:hover {
            transform: translateY(-5px);
            box-shadow: 0 10px 25px rgba(0,0,0,0.15);
        }

        .btn {
            padding: 8px 15px;
            background: #0078D4;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            margin: 5px;
        }

        .btn:hover {
            background: #005a9e;
        }

        select {
            padding: 8px;
            margin: 5px;
            border-radius: 6px;
            border: 1px solid #ccc;
        }

        .message {
            color: #1a3d6f;
            font-weight: bold;
        }

        .top-info {
            display: flex;
            justify-content: space-between;
            align-items: center;
            gap: 25px;
        }

        .user-info {
            font-size: 18px;
            font-weight: bold;
            color: #1a3d6f;
        }

        .progress-wrapper {
            width: 350px;
        }

        .progress-container {
            width: 100%;
            background: #ddd;
            border-radius: 10px;
            overflow: hidden;
        }

        .progress-bar {
            height: 24px;
            width: 0%;
            background: #0078D4;
            color: white;
            text-align: center;
            line-height: 24px;
            font-size: 13px;
        }

        .guide-card {
            border: 1px solid #ddd;
            border-radius: 12px;
            overflow: hidden;
            background: white;
        }

        .guide-title-bar {
            display: flex;
            justify-content: space-between;
            align-items: center;
            background: #0078D4;
            color: white;
            padding: 14px;
            font-size: 20px;
            font-weight: bold;
        }

        .guide-description {
            min-height: 260px;
            max-height: 430px;
            overflow-y: auto;
            text-align: left;
            padding: 18px;
            white-space: pre-wrap;
            line-height: 1.6;
            color: #333;
        }

        .categorie-box {
            margin-bottom: 15px;
        }

        .confirm-area {
            text-align: right;
            margin-top: 15px;
        }
    </style>
</head>

<body>

<form runat="server">

    <div style="
        display:flex;
        align-items:center;
        justify-content:center;
        flex-direction:column;
        margin-bottom:30px;
    ">
        <img src="images/canada-logo.png"
             style="width:120px;height:auto;border-radius:10px;
             box-shadow:0 5px 15px rgba(0,0,0,0.2);" />

        <h2 style="margin-top:10px;color:#1a3d6f;">
            Welcome Canada
        </h2>
    </div>

    <h1>Accueil</h1>

    <div class="container">

        <div class="card">
            <div class="top-info">

                <div class="user-info">
                    <asp:Label ID="lblNomPrenom" runat="server"></asp:Label>
                </div>

                <div class="progress-wrapper">
                    <div class="progress-container">
                        <div id="progressBar" runat="server" class="progress-bar">0%</div>
                    </div>
                    <asp:Label ID="lblProgression" runat="server" CssClass="message"></asp:Label>
                </div>

            </div>
        </div>

        <div class="card" style="text-align:center;">
            <asp:Label ID="lblBienvenue" runat="server" CssClass="message"></asp:Label>

            <br /><br />

            <asp:Button ID="btnViewGuides" runat="server"
                Text="Voir les guides"
                CssClass="btn"
                OnClick="btnViewGuides_Click" />

            <asp:Button ID="BtnLogement" runat="server"
                Text="Chercher un logement"
                CssClass="btn"
                OnClick="BtnLogement_Click" />

            <asp:Button ID="btnLogout" runat="server"
                Text="Déconnexion"
                CssClass="btn"
                OnClick="BtnLogout_Click" />
        </div>

        <asp:Panel ID="pnlGuides" runat="server" Visible="false">

            <div class="card">

                <h3>Guides</h3>

                <div class="categorie-box">
                    Catégorie :
                    <asp:DropDownList ID="ddlCategorieGuide" runat="server"
                        AutoPostBack="true"
                        OnSelectedIndexChanged="ddlCategorieGuide_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>

                <div class="guide-card">

                    <div class="guide-title-bar">
                        <asp:Label ID="lblTitreGuide" runat="server"></asp:Label>

                        <asp:CheckBox ID="chkGuideVu" runat="server" />
                    </div>

                    <div class="guide-description">
                        <asp:Label ID="lblDescriptionGuide" runat="server"></asp:Label>
                    </div>

                </div>

                <div class="confirm-area">
                    <asp:Button ID="btnConfirmerGuides" runat="server"
                        Text="Confirmer"
                        CssClass="btn"
                        Visible="false"
                        OnClick="btnConfirmerGuides_Click" />
                </div>

            </div>

        </asp:Panel>

    </div>

</form>

</body>
</html>