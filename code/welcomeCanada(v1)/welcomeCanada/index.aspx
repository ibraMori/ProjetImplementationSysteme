<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="welcomeCanada.index" %>
<!DOCTYPE html>
<html lang="fr">
<head runat="server">
    <meta charset="utf-8" />
    <title>CanadaWelcome - Accueil</title>

    <!-- Bootstrap CDN -->
    <link rel="stylesheet" 
          href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" />

    <style>
        body {
            background: #f5f7fa;
            font-family: Arial, sans-serif;
        }
        .hero {
            margin-top: 80px;
            text-align: center;
        }
        .hero h1 {
            font-size: 42px;
            font-weight: bold;
            color: #1a3d6f;
        }
        .hero p {
            font-size: 18px;
            color: #555;
            margin-top: 15px;
        }
        .btn-custom {
            width: 200px;
            margin: 10px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div class="container hero">
            <h1>Bienvenue sur CanadaWelcome</h1>
            <p>L’application qui accompagne les nouveaux immigrants dans leurs démarches essentielles.</p>

            <div class="mt-4">
                <a href="pageConexion.aspx" class="btn btn-primary btn-custom">Connexion</a>
                <a href="pageConexion.aspx" class="btn btn-outline-primary btn-custom">Inscription</a>
            </div>
        </div>

    </form>
</body>
</html>

