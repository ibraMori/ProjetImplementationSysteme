<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageBanques.aspx.cs" Inherits="welcomeCanada.PageBanques" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Banques Montréal</title>

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
            width: 800px;
            margin: auto;
        }

        .card {
            background: white;
            margin: 15px 0;
            padding: 15px;
            border-radius: 12px;
            box-shadow: 0 4px 15px rgba(0,0,0,0.08);
            transition: all 0.3s ease;
        }

        .card:hover {
            transform: translateY(-5px);
            box-shadow: 0 10px 25px rgba(0,0,0,0.15);
        }

        .header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            cursor: pointer;
        }

        .bank-name {
            font-size: 18px;
            font-weight: bold;
            color: #1a3d6f;
        }

        .arrow {
            font-size: 20px;
            transition: transform 0.3s ease;
        }

        .details {
            max-height: 0;
            overflow: hidden;
            opacity: 0;
            transition: all 0.4s ease;
            margin-top: 0;
            color: #444;
        }

        .details.show {
            max-height: 200px;
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

<h1>🏦 Banques à Montréal</h1>

<div class="container">

    <div class="card">
        <div class="header" onclick="toggleDetails('rbc', 'a1')">
            <span class="bank-name">RBC - Royal Bank</span>
            <span class="arrow" id="a1">▼</span>
        </div>
        <div class="details" id="rbc">
            ✔ Très populaire pour nouveaux arrivants<br />
            ✔ Ouverture rapide<br />
            ✔ Bonne application mobile<br />
            ✔ Frais étudiants réduits
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('td', 'a2')">
            <span class="bank-name">TD Bank</span>
            <span class="arrow" id="a2">▼</span>
        </div>
        <div class="details" id="td">
            ✔ Ouverture facile<br />
            ✔ Service client 24/7<br />
            ✔ Bon pour étudiants<br />
            ✔ Cartes de crédit accessibles
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('scotia', 'a3')">
            <span class="bank-name">Scotiabank</span>
            <span class="arrow" id="a3">▼</span>
        </div>
        <div class="details" id="scotia">
            ✔ Très bon pour immigrants<br />
            ✔ Offres étudiants<br />
            ✔ Transferts internationaux<br />
            ✔ 1 an sans frais
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('bmo', 'a4')">
            <span class="bank-name">BMO</span>
            <span class="arrow" id="a4">▼</span>
        </div>
        <div class="details" id="bmo">
            ✔ Frais réduits<br />
            ✔ Bon pour étudiants<br />
            ✔ Carte débit gratuite<br />
            ✔ Application simple
        </div>
    </div>

    <div class="card">
        <div class="header" onclick="toggleDetails('desjardins', 'a5')">
            <span class="bank-name">Desjardins</span>
            <span class="arrow" id="a5">▼</span>
        </div>
        <div class="details" id="desjardins">
            ✔ Très populaire au Québec<br />
            ✔ Service en français<br />
            ✔ Idéal étudiants<br />
            ✔ Frais réduits ou gratuits<br />
            ✔ Coopérative différente des banques
        </div>
    </div>

</div>

</form>

</body>
</html>