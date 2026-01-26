# Cahier des charges (SRS léger) — <Nom du projet>
**Équipe :** Hajar Chobani, Rayane Achoukairi ,Ibrahim Moriba Camara
**Date :** <2026-01-25>  
**Version :** <v0.1 / v1.0>

---

## 1. Contexte & objectif
- **Contexte :** Les nouveaux immigrants au Canada font face à des démarches administratives et logistiques complexes, comme obtenir le NAS, la carte de transport, et aussi l'ouverture de compte bancaire et la recherche de logement. Les informations sont réparties sur plusieurs plateformes, ce qui rend le processus d’intégration long et difficile. Aussi des fois les nouveaux immigrants ne savent pas toutes les démarches administratives à faire. C’est pour cela qu'on a décidé de faire une application simple et accessible.

- **Objectif principal :** Nous avons décidé de développer une application centralisée appelée CanadaWelcome
Nous choisissons une application unique regroupant les services essentiels à l’intégration des nouveaux immigrants.
Pour faciliter, structurer et accélérer leur intégration à la société canadienne et pour la réduction du stress pour les nouveaux immigrants et éviter d'avoir des informations incomplètes ou non à jour
- **Parties prenantes :**
- Utilisateurs : Nouveaux immigrants au Canada qui utilisent l’application pour s’intégrer (NAS, logement, transport, banque, etc)
- Client : Gouvernement Canada avec Immigration IRCC (Immigration, réfugiés et citoyenneté Canada)
- Product Owner
-Scrum master
- Équipe de développeurs (programmeurs, designers)
- Testeurs
- Support IT

## 2. Portée (Scope)
### 2.1 Inclus (IN)
- IN-1: guide d’intégration pour les nouveaux immigrants 
- IN-2: information sur l'obtention du NAS
- IN-3: Guide pour l'ouverture de compte bancaire
- IN-4: Information sur les cartes de transport
- IN-5: Recherche de logement par ville et par budget
- IN-6: Conseils pratiques pour l'installation au Canada
- IN-7: interface simple et accessible en français

### 2.2 Exclu (OUT)
OUT-1 : Services de paiement en ligne
OUT-2 : Gestion des dossiers d’immigration officiels
OUT-3 : Assistance juridique ou légale personnalisée
OUT-4 : Réservation directe de logements
OUT-5 : Support client en temps réel chat ou appel

---

## 3. Acteurs / profils utilisateurs
- **Acteur A :** Nouvel immigrant
- Rôle : Utilise l’application pour s’intégrer au Canada
- Besoins : Informations claires sur le NAS, le logement, la carte de transport et le compte bancaire
- Contraintes : Peu d’expérience avec les démarches canadiennes, stress, manque de temps
- **Acteur B :** Administrateur 
- Rôle : Gère et met à jour le contenu de l’application
- Besoins : interface simple pour modifier les informations
- Contraintes : Doit maintenir les données à jour

---

## 4. Exigences fonctionnelles (FR)
- **FR-1 :** Le système doit aider et guider les nouveaux immigrants dans les démarches administratives (NAS, carte de transport, compte bancaire).
- **FR-2 :** Le système doit afficher des informations sur les options de logement selon la ville et le budget.
- **FR-3 :** Le système doit afficher les informations selon le statut de l’immigrant (étudiant, travailleur).
-  **FR-4 :** Le système doit centraliser toutes les informations essentielles dans une seule application.
- **FR-5 :** Le système doit offrir une interface simple et facile à utiliser.

---

## 5. Exigences non fonctionnelles (NFR)
> Performance / sécurité / disponibilité / UX / maintenabilité…
- **NFR-1 (Performance) :** Le système doit répondre aux actions de l’utilisateur en moins de 2 secondes.
- **NFR-2 (Sécurité) :** Le système doit protéger les données personnelles et authentifier les administrateurs.
- **NFR-3 (UX) :** Le parcours de l’utilisateur doit être simple et accessible en ≤ 3 clics pour chaque tâche principale.
- **NFR-4 (Qualité) :** L’application doit toujours fonctionner, tous les jours et toutes les heures.

---

## 6. Contraintes
- **C-1 (Technologie) :** les langages utilisés Backend: C# et Frontend: HTML, CSS.  MySQL pour les bases de données. Le Framework utilisé .NET Framework
- **C-2 (Plateforme) :** application Web
- **C-3 (Délai) :** Livraison avant le 22 avril
- **C-4 (Outils) :** GIT, Visual Studio, Teams pour les réunions. Draw.io pour la conception des UML. 

---

## 7. Données & règles métier (si applicable)

- **Entités principales :** 

  -Utilisateurs (Nouveau Immigrant): numéro de passeport, nom, prénom, statut d'immigration (étudiant, travailleur), province de résidence, adresse e-mail, langue préférée.

  -données de connexion: numéro d'utilisateur, numéro de passeport, mot de passe.

  -progression d'intégration : oui ou non possède le Nas, carte de transport, carte bancaire

  -données de logement: dimensions de l'appartement, adresse de l'appartement, prix.


- **Règles métier :** <validation, calculs, permissions, etc.>

  -Un utilisateur doit être inscrit pour utiliser les fonctionnalités de l'application.

  -Un utilisateur peut modifier son profil et son niveau d'intégration.

  -Un utilisateur ne peut avoir qu’un seul compte avec une adresse e-mail unique.

  -Le mot de passe doit respecter des règles de sécurité minimales.

  -Les données personnelles doivent être stockées de manière sécurisée.

  - Le contenu affiché doit être adapté dépendamment de la langue préférée de l'utilisateur

  - Le système doit être disponible 24 h/24, sauf maintenance.
 
---

## 8. Hypothèses & dépendances
### 8.1 Hypothèses
H-1 : Les utilisateurs possèdent un smartphone ou un ordinateur et savent l’utiliser.
H-2 : Les utilisateurs disposent d’un accès à Internet.
H-3 : Les informations fournies par les sites gouvernementaux canadiens sont accessibles au public.
H-4 : Les utilisateurs comprennent le français ou l'anglais.
H-5 : Les utilisateurs sont des nouveaux immigrants ou des personnes récemment arrivés au Canada

### 8.2 Dépendances
D-1 : Sites officiels du gouvernement du Canada (NAS, transport, services publics).
D-2 : API ou plateformes externes pour les informations sur le logement.
D-3 : Base de données pour stocker les données des utilisateurs.
D-4 : Environnement Visual Studio pour le développement de l’application.
D-5 : Connexion Internet pour accéder aux données externes.


## 9. Critères d’acceptation globaux (Définition of Done – mini)
- [ ] Fonctionnalités livrées et testées
- [ ] Tests unitaires présents
- [ ] Gestion d’erreurs minimale
- [ ] Documentation à jour (UML + ADR si requis)
