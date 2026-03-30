<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLogement.aspx.cs" Inherits="welcomeCanada.PageLogement" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Logements</title>

    <style>
        body { font-family: Arial; margin:40px; }
        input { padding:6px; margin:5px; }
        .btn { padding:8px 15px; background:#0078D4; color:white; border:none; cursor:pointer; }
        .btn:hover { background:#005a9e; }
        .message { color:red; }
    </style>
</head>

<body>

    <form runat="server">

        <h2>Rechercher un logement</h2>

        Ville :
        <asp:TextBox ID="txtVille" runat="server" />

        Budget max :
        <asp:TextBox ID="txtPrixMax" runat="server" />

        Dimension min :
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

        <br /><br />

        <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>

        <br />

        <asp:GridView ID="GridViewLogements"
            runat="server"
            AutoGenerateColumns="false"
            BorderWidth="1">

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Titre" HeaderText="Titre" />
                <asp:BoundField DataField="Ville" HeaderText="Ville" />
                <asp:BoundField DataField="Prix" HeaderText="Prix ($)" />
                <asp:BoundField DataField="Dimension" HeaderText="Dimension (m²)" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
            </Columns>

        </asp:GridView>

    </form>

</body>
</html>