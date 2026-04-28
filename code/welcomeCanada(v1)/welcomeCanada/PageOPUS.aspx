<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageOPUS.aspx.cs" Inherits="welcomeCanada.PageOPUS" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Carte OPUS</title>

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
            transition: 0.3s;
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

<!-- HEADER (corrigé) -->
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

<h1>🚌 Carte OPUS Montréal</h1>

<div class="container">

    <div class="section-title">🎓 Étudiants</div>

    <div class="card">
        <div class="header" onclick="toggleDetails('et1','a1')">
            <span class="title">📄 Documents nécessaires</span>
            <span class="arrow" id="a1">▼</span>
        </div>
        <div class="details" id="et1">
            ✔ Carte étudiante valide<br />
            ✔ Preuve d’inscription scolaire<br />
            ✔ Photo récente<br />
            ✔ Pièce d’identité
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('et2','a2')">
            <span class="title">⭐ Avantages étudiants</span>
            <span class="arrow" id="a2">▼</span>
        </div>
        <div class="details" id="et2">
            ✔ Transport illimité réduit<br />
            ✔ Économie mensuelle importante<br />
            ✔ Métro + bus inclus<br />
            ✔ Recharge facile
        </div>
    </div>

    <div class="section-title">💼 Travailleurs</div>

    <div class="card">
        <div class="header" onclick="toggleDetails('tr1','a3')">
            <span class="title">📄 Documents nécessaires</span>
            <span class="arrow" id="a3">▼</span>
        </div>
        <div class="details" id="tr1">
            ✔ Permis de travail valide<br />
            ✔ Pièce d’identité (passeport)<br />
            ✔ Photo récente<br />
            ✔ Adresse au Canada
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('tr2','a4')">
            <span class="title">⭐ Avantages travailleurs</span>
            <span class="arrow" id="a4">▼</span>
        </div>
        <div class="details" id="tr2">
            ✔ Accès illimité transport STM<br />
            ✔ Facilité déplacement travail<br />
            ✔ Tarifs mensuels adaptés<br />
            ✔ Carte rechargeable
        </div>
    </div>

</div>

</form>

</body>
</html>