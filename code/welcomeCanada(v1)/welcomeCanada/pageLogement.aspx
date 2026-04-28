<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLogement.aspx.cs" Inherits="welcomeCanada.PageLogement" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Logements</title>

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

        input {
            padding: 8px;
            margin: 5px;
            border-radius: 6px;
            border: 1px solid #ccc;
        }

        .btn {
            padding: 8px 15px;
            background: #0078D4;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
        }

        .btn:hover {
            background: #005a9e;
        }

        .message {
            color: red;
            margin-top: 10px;
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
    </style>

</head>

<body>

<form runat="server">

<!-- HEADER CORRIGÉ -->
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

<h1>🏠 Recherche de logement</h1>

<div class="container">

    <div class="card">

        <h3>🔍 Filtrer</h3>

        Ville:
        <asp:TextBox ID="txtVille" runat="server" />

        Budget max:
        <asp:TextBox ID="txtPrixMax" runat="server" />

        Dimension min:
        <asp:TextBox ID="txtDimensionMin" runat="server" />

        <br />

        <asp:Button ID="btnFiltrer" runat="server"
            Text="Filtrer"
            CssClass="btn"
            OnClick="btnFiltrer_Click" />

        <asp:Button ID="btnReset" runat="server"
            Text="Reset"
            CssClass="btn"
            OnClick="btnReset_Click" />

        <br />

        <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>

    </div>

    <div class="card">

        <h3>📋 Résultats</h3>

        <asp:GridView ID="GridViewLogements"
            runat="server"
            AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Titre" HeaderText="Titre" />
                <asp:BoundField DataField="Ville" HeaderText="Ville" />
                <asp:BoundField DataField="Prix" HeaderText="Prix ($)" />
                <asp:BoundField DataField="Dimension" HeaderText="Dimension (m²)" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
            </Columns>

        </asp:GridView>

    </div>

</div>

</form>

</body>
</html>