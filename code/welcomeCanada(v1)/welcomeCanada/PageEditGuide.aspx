<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageEditGuide.aspx.cs" Inherits="welcomeCanada.PageEditGuide" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Modifier Guide</title>

    <style>
        body {
            font-family: 'Segoe UI', Arial;
            background: linear-gradient(to right, #eef2f7, #f8fbff);
            margin: 0;
            padding: 20px;
        }

        h1 {
            text-align: center;
            color: #1a3d6f;
            margin-bottom: 15px;
        }

        h2 {
            color: #1a3d6f;
            margin: 5px 0;
        }

        .container {
            width: 700px; 
            margin: auto;
        }

        .card {
            background: white;
            padding: 15px; 
            border-radius: 10px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.08);
        }

        .btn {
            padding: 7px 12px;
            background: #0078D4;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin: 4px;
        }

        .btn:hover {
            background: #005a9e;
        }

        input, textarea, select {
            padding: 7px;
            margin: 4px 0;
            border-radius: 5px;
            border: 1px solid #ccc;
            width: 95%;
        }

        textarea {
            height: 220px;
            resize: vertical;
            overflow-y: auto;
        }

        .message-success {
            color: green;
            font-weight: bold;
        }

        .message-error {
            color: red;
            font-weight: bold;
        }

        .form-section {
            text-align: center;
        }

        .buttons {
            margin-top: 10px;
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
        margin-bottom:15px; 
    ">
        <img src="images/canada-logo.png"
             style="width:90px; 
             height:auto;border-radius:8px;
             box-shadow:0 4px 10px rgba(0,0,0,0.2);" />

        <h2>Welcome Canada</h2>
    </div>

    <h1>Modifier Guide</h1>

    <div class="container">

        <div class="card">

            <asp:Label ID="lblMessage" runat="server" CssClass="message-success" />
            <asp:Label ID="lblError" runat="server" CssClass="message-error" />

            <div class="form-section">

                <asp:TextBox ID="txtTitre" runat="server" Placeholder="Titre" />

                <asp:DropDownList ID="ddlCategorie" runat="server" />

                <asp:DropDownList ID="ddlTypeUtilisateur" runat="server" />

                <asp:TextBox ID="txtDescription" runat="server"
                    TextMode="MultiLine"
                    Placeholder="Description" />

                <div class="buttons">
                    <asp:Button ID="btnSave" runat="server"
                        Text="Enregistrer"
                        CssClass="btn"
                        OnClick="btnSave_Click" />

                    <asp:Button ID="btnRetour" runat="server"
                        Text="Retour"
                        CssClass="btn"
                        OnClick="btnRetour_Click" />
                </div>

            </div>

        </div>

    </div>

</form>

</body>
</html>