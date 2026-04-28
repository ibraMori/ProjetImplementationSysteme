ADR-01 — Choix d’une application Web centralisée pour Welcome Canada

Statut : Accepté
Date : 2026-01-25
Décideurs : Hajar Chobani, Rayane Achoukairi, Ibrahim Moriba Camara
Contexte : Application d’intégration des nouveaux immigrants au Canada

1. Contexte
Problème

Les nouveaux immigrants au Canada doivent accomplir plusieurs démarches importantes dès leur arrivée, notamment :

obtenir un NAS
ouvrir un compte bancaire
accéder aux services de transport
trouver un logement

Ces informations sont généralement dispersées sur plusieurs plateformes, parfois difficiles à comprendre et pas toujours à jour. Cela rend le processus d’intégration plus long et complexe.

Contraintes
temps de développement limité
équipe de petite taille
nécessité d’une solution simple et accessible
obligation d’utiliser les concepts vus en cours (UML, design patterns, structuration du code)
Objectifs
centraliser les informations importantes
simplifier l’expérience utilisateur
proposer une application claire et facile à utiliser
respecter les exigences académiques du projet
2. Décision

Le choix retenu est de développer une application Web centralisée appelée Welcome Canada.

Cette application regroupe :

les guides d’intégration (NAS, banque, transport, logement)
un système de progression pour l’utilisateur
une recherche de logement
une interface administrateur pour gérer les guides et les utilisateurs

Le choix d’une application Web (ASP.NET WebForms) permet un développement plus rapide et un accès facile sans installation.

3. Alternatives considérées
Option A — Site web statique

Avantages :

facile à développer
rapide à mettre en place

Inconvénients :

pas de gestion des utilisateurs
pas de personnalisation
aucune logique de progression

Cette option a été rejetée car elle ne répond pas aux besoins du projet.

Option B — Application mobile

Avantages :

meilleure expérience sur téléphone
application dédiée

Inconvénients :

développement plus long
complexité plus élevée
besoin de gérer plusieurs plateformes

Cette option a été rejetée en raison des contraintes de temps.

Option retenue — Application Web

Cette option permet de concilier simplicité, accessibilité et fonctionnalités.

4. Justification
Accessibilité

L’application Web est accessible depuis n’importe quel appareil disposant d’un navigateur, sans installation.

Centralisation

Toutes les informations importantes sont regroupées sur une seule plateforme, ce qui simplifie le parcours utilisateur.

Personnalisation

Grâce au système de connexion :

les utilisateurs ont un profil
les guides affichés sont adaptés à leur situation
une progression est suivie
Cohérence avec le cours

Cette solution permet d’intégrer les concepts étudiés :

structuration du projet
diagrammes UML
design patterns
5. Conséquences
Points positifs
meilleure organisation des données
expérience utilisateur améliorée
application évolutive
code structuré
Risques et limites
nécessité de sécuriser les comptes utilisateurs
dépendance à une base de données
logique backend plus complexe qu’un site statique
Impact sur l’architecture

L’application suit une architecture en couches :

Interface Web (WebForms)
        ↓
Services (AuthService, GuideService, AdminService)
        ↓
Base de données (SQL)
Impact sur le code

Création de plusieurs services :

AuthService : gestion de l’authentification
GuideService : gestion des guides
AdminService : gestion des utilisateurs et administration

Entités principales :

Utilisateur
Guide
Logement
Progression
Impact sur les design patterns

Les choix effectués ont permis d’intégrer :

Singleton pour la gestion de la base de données
State pour gérer les états de la page d’accueil
Observer pour filtrer les guides selon le type d’utilisateur
6. Plan d’implémentation
création de la structure du projet
implémentation de l’authentification
connexion à la base de données
gestion des guides
ajout des design patterns (State et Observer)
développement de l’interface administrateur
ajout de la recherche de logement
tests et validation
7. Validation
Conditions de validation

La solution est validée si :

l’utilisateur peut se connecter
les guides sont affichés selon le profil
la progression fonctionne
la recherche de logement est opérationnelle
l’administrateur peut gérer les guides
les données sont correctement enregistrées
Critères de qualité
interface claire
application fonctionnelle
temps de réponse acceptable
cohérence entre UML et code
8. Liens
diagrammes UML (classes, cas d’utilisation, composants)
dépôt GitHub du projet
dossier /documentation
outil de gestion de projet (à ajouter)