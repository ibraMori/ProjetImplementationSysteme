<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageNAS.aspx.cs" Inherits="welcomeCanada.PageNAS" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>NAS Canada</title>

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

        .section-title {
            font-size: 20px;
            font-weight: bold;
            color: #0078D4;
            margin-top: 30px;
        }

        .card {
            background: white;
            margin: 15px 0;
            padding: 15px;
            border-radius: 12px;
            box-shadow: 0 4px 15px rgba(0,0,0,0.08);
            transition: 0.3s ease;
        }

        .card:hover {
            transform: translateY(-5px);
            box-shadow: 0 10px 25px rgba(0,0,0,0.15);
        }

        .header {
            display: flex;
            justify-content: space-between;
            cursor: pointer;
        }

        .title {
            font-weight: bold;
            color: #1a3d6f;
        }

        .arrow {
            transition: transform 0.3s ease;
        }

        .details {
            max-height: 0;
            overflow: hidden;
            opacity: 0;
            transition: all 0.4s ease;
        }

        .details.show {
            max-height: 300px;
            opacity: 1;
            margin-top: 10px;
        }

        .arrow.rotate {
            transform: rotate(180deg);
        }
    </style>

    <script>
        function toggleDetails(id, arrowId) {
            document.getElementById(id).classList.toggle("show");
            document.getElementById(arrowId).classList.toggle("rotate");
        }
    </script>
</head>

<body>

<form runat="server">

<!-- HEADER LOGO -->
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

<h1>🧾 Numéro d’Assurance Sociale (NAS)</h1>

<div class="container">

    <!-- Étudiants -->
    <div class="section-title">🎓 Étudiants</div>

    <div class="card">
        <div class="header" onclick="toggleDetails('e1','a1')">
            <span class="title">📄 Documents nécessaires</span>
            <span class="arrow" id="a1">▼</span>
        </div>
        <div class="details" id="e1">
            ✔ Permis d’études valide<br />
            ✔ Passeport<br />
            ✔ Preuve d’adresse au Canada<br />
            ✔ Contrat d’école / inscription
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('e2','a2')">
            <span class="title">📌 Comment obtenir le NAS</span>
            <span class="arrow" id="a2">▼</span>
        </div>
        <div class="details" id="e2">
            ✔ Aller à Service Canada<br />
            ✔ Demande en ligne ou sur place<br />
            ✔ Recevoir le NAS immédiatement
        </div>
    </div>

    <!-- Travailleurs -->
    <div class="section-title">💼 Travailleurs</div>

    <div class="card">
        <div class="header" onclick="toggleDetails('t1','a3')">
            <span class="title">📄 Documents nécessaires</span>
            <span class="arrow" id="a3">▼</span>
        </div>
        <div class="details" id="t1">
            ✔ Permis de travail valide<br />
            ✔ Passeport<br />
            ✔ Preuve d’adresse<br />
            ✔ Contrat d’emploi (si disponible)
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('t2','a4')">
            <span class="title">⚠️ Informations importantes</span>
            <span class="arrow" id="a4">▼</span>
        </div>
        <div class="details" id="t2">
            ✔ Obligatoire pour travailler au Canada<br />
            ✔ Ne jamais partager le NAS<br />
            ✔ Utilisé pour impôts et emploi
        </div>
    </div>

</div>

</form>

</body>
</html>