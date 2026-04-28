<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="welcomeCanada.index" %>
<!DOCTYPE html>
<html lang="fr">
<head runat="server">
    <meta charset="utf-8" />
    <title>CanadaWelcome - Accueil</title>

    <!-- Bootstrap CDN -->
    <link rel="stylesheet" 
          href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" />
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
                <a href="PageConnexion.aspx" class="btn btn-primary btn-custom">Connexion</a>
                <a href="PageInscription.aspx" class="btn btn-outline-primary btn-custom">Inscription</a>
            </div>
        </div>

    </form>
</body>
</html>

