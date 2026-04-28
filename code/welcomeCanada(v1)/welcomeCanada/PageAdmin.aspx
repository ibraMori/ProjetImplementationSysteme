<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageAdmin.aspx.cs" Inherits="welcomeCanada.PageAdmin" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Admin</title>

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

        input, textarea, select {
            padding: 8px;
            margin: 5px;
            border-radius: 6px;
            border: 1px solid #ccc;
        }

        textarea {
            width: 95%;
        }

        .message {
            color: red;
            font-weight: bold;
        }

        table {
            width: 100%;
            border-collapse: collapse;
        }

        th {
            background: #0078D4;
            color: white;
            padding: 10px;
        }

        td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }

        tr:hover {
            background: #f2f2f2;
        }

        .form-section {
            margin-top: 15px;
        }

        .filter-section {
            margin-bottom: 15px;
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
        <asp:Button ID="btnLogout" runat="server"
        Text="Déconnexion"
        CssClass="btn"
        OnClick="btnLogout_Click" />
    </div>

    <h1>Administration</h1>

    <div class="container">

        <div class="card">
            <h3>Guides</h3>

            <asp:GridView ID="gvGuides" runat="server"
                AutoGenerateColumns="false"
                DataKeyNames="Id"
                OnRowCommand="gvGuides_RowCommand">

                <SelectedRowStyle BackColor="#d1ecf1" Font-Bold="true" />

                <Columns>
                    <asp:BoundField DataField="Titre" HeaderText="Titre" />
                    <asp:BoundField DataField="Categorie" HeaderText="Catégorie" />
                    <asp:BoundField DataField="TypeUtilisateur" HeaderText="Type utilisateur" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server"
                                Text="Modifier"
                                CssClass="btn"
                                CommandName="EditGuide"
                                CommandArgument="<%# Container.DataItemIndex %>" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server"
                                Text="Supprimer"
                                CssClass="btn"
                                CommandName="DeleteGuide"
                                CommandArgument="<%# Container.DataItemIndex %>"
                                OnClientClick="return confirm('Supprimer ce guide ?');" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div class="card">
            <h3>Ajouter un guide</h3>

            <asp:Label ID="lblError" runat="server" CssClass="message" />
            <br />

            <div class="form-section">
                <asp:TextBox ID="txtTitre" runat="server" Placeholder="Titre" />
                <br />

                <asp:DropDownList ID="ddlCategorie" runat="server" />
                <br />

                <asp:DropDownList ID="ddlTypeUtilisateurGuide" runat="server" />
                <br />

                <asp:TextBox ID="txtDescription" runat="server"
                    TextMode="MultiLine"
                    Rows="8"
                    Placeholder="Description" />
                <br />

                <asp:Button ID="btnAddGuide" runat="server"
                    Text="Ajouter"
                    CssClass="btn"
                    OnClick="btnAddGuide_Click" />
            </div>
        </div>

        <div class="card">
            <h3>Utilisateurs</h3>

            <div class="filter-section">
                <asp:TextBox ID="txtSearchNom" runat="server" Placeholder="Nom" />

                <asp:DropDownList ID="ddlTypeUser" runat="server" />

                <asp:Button ID="btnSearchUser" runat="server"
                    Text="Rechercher"
                    CssClass="btn"
                    OnClick="btnSearchUser_Click" />
            </div>

            <asp:GridView ID="gvUsers" runat="server"
                AutoGenerateColumns="false"
                DataKeyNames="Id"
                OnRowCommand="gvUsers_RowCommand">

                <SelectedRowStyle BackColor="#d1ecf1" Font-Bold="true" />

                <Columns>
                    <asp:BoundField DataField="Nom" HeaderText="Nom" />
                    <asp:BoundField DataField="Prenom" HeaderText="Prénom" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="TypeUtilisateur" HeaderText="Type" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server"
                                Text="Supprimer"
                                CssClass="btn"
                                CommandName="DeleteUser"
                                CommandArgument="<%# Container.DataItemIndex %>"
                                OnClientClick="return confirm('Supprimer cet utilisateur ?');" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

    </div>

</form>

</body>
</html>