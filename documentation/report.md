Rapport de révision et d’amélioration du projet Welcome Canada
1. Introduction
Dans le cadre de ce projet, une révision complète de l’application Welcome Canada a été réalisée. Cette phase d’amélioration a concerné :

la qualité et la cohérence du code ;
les diagrammes UML ;
L’architecture logicielle ;
Les fonctionnalités offertes à l’utilisateur.
À la suite des commentaires reçus, plusieurs incohérences ont été corrigées et de nouvelles fonctionnalités ont été intégrées, afin d’obtenir un projet plus structuré, professionnel et conforme aux exigences du cours.

2. Organisation du projet
Le projet suit une structure logique et homogène :



/documentation   → rapport (report.md), diagrammes UML, décisions architecturales (ADR)
/code            → application ASP.NET WebForms, organisée en :
                   ├── Models
                   ├── Services
                   ├── Database
                   ├── Pages (UI)

Un fichier README détaillé a été ajouté pour faciliter l’installation et l’exécution.
Une vidéo de démonstration (≤ 2 minutes) peut accompagner le projet pour illustrer les principales fonctionnalités.

3. Améliorations générales
3.1 Qualité du code et documentation
Correction des fautes et incohérences.
Uniformisation des conventions de nommage (classes, méthodes, variables).
Amélioration de la lisibilité globale.
Structuration conforme au modèle MVC (Model–View–Controller).
4. Fonctionnalités implémentées
4.1 Authentification
Connexion utilisateur avec email et mot de passe.
Identification du type d’utilisateur (étudiant ou travailleur).
Gestion complète des sessions (connexion, déconnexion, maintien de l’état).
4.2 Gestion des guides
Côté utilisateur :

Affichage des guides selon le profil.
Filtrage par catégorie (Banque, NAS, OPUS, Logement).
Interface améliorée (titres visuels, descriptions longues, cases à cocher pour marquer un guide comme vu).
Suivi de progression :

Barre de progression dynamique, calculée selon les guides consultés.
Mise à jour automatique après validation.
4.3 Interface administrateur
Ajout, modification et suppression de guides.
Visualisation via GridView.
Gestion des utilisateurs (affichage, suppression, filtrage par type).
4.4 Recherche de logement
Filtrage par ville, budget et superficie.
Affichage des résultats dans une interface moderne et claire.
5. Design patterns utilisés
5.1 Singleton (ConnexionDB)
Centralisation de la gestion de la base de données.
Évite la création multiple de connexions et améliore l’efficacité.
5.2 State Pattern (Home)
Implémentation : IState, HomeContext, BienvenueState, GuidesState, LogoutState.
Fonction : gère les différents états de la page d’accueil (accueil, guides, déconnexion).
Avantage : supprime les structures conditionnelles répétitives et rend le comportement extensible.

5.3 Observer Pattern (Guides)
Implémentation : GuideSubject, EtudiantGuideObserver, TravailleurGuideObserver.
Fonction : filtre automatiquement les guides affichés selon le type d’utilisateur.
Avantage : séparation claire des responsabilités, extensibilité pour de nouveaux rôles.

6. Diagrammes UML
6.1 Diagramme de classes
Aligné sur l’implémentation.
Intègre les design patterns (State, Observer, Singleton).
Relations corrigées et cohérentes.
6.2 Diagramme de cas d’utilisation
Orthographe et libellés revus.
Définition précise des acteurs : Utilisateur et Administrateur.
Cas d’utilisation alignés sur les fonctionnalités réelles.
6.3 Diagramme de composants
Ce diagramme présente la structure logicielle globale et les interactions entre les composants du système.

Représentation textuelle simplifiée :



[WebForms UI]
     |
     | appels utilisateurs
     v
[AuthService] ----> [Database (SQL)]
     |
     v
[GuideService] ----> [Database (SQL)]
     |
     v
[AdminService] ----> [Database (SQL)]
Description :

WebForms UI : Interface de présentation avec logique de navigation.
AuthService : Gestion de l’authentification et des sessions utilisateur.
GuideService : Gestion des guides et filtrage selon le profil.
AdminService : Gestion des contenus et des utilisateurs côté administrateur.
Database (SQL) : Stockage unique des données, exploité via un Singleton.
Ce découpage met en évidence une architecture en couches claire et faiblement couplée, garantissant la modularité et la maintenabilité du projet.

7. Prototype fonctionnel
Le prototype mis en place permet de :

se connecter à l’application ;
consulter et filtrer des guides personnalisés ;
suivre la progression individuelle ;
rechercher un logement selon des critères ;
administrer les guides et les utilisateurs.
8. Architecture Decision Record (ADR)
Les principales décisions documentées sont :

Choix du framework : ASP.NET WebForms pour sa rapidité et sa simplicité.
Design patterns :
State → gestion dynamique de l’interface utilisateur.
Observer → filtrage automatisé du contenu.
Singleton → gestion centralisée de la base de données.
Séparation logique des services :
AuthService
GuideService
AdminService
9. Gestion de projet
L’utilisation d’un outil comme Trello ou GitHub Projects est envisagée pour :

suivre l’avancement des tâches ;
planifier les prochaines mises à jour ;
organiser les fonctionnalités et les correctifs.
Un lien vers cet outil pourra être intégré au dépôt GitHub.

10. Conclusion
Les améliorations apportées à Welcome Canada garantissent désormais un projet :

mieux structuré et conforme aux normes MVC ;
enrichi de fonctionnalités pertinentes et stables ;
soutenu par une architecture claire, modulable et documentée.
L’intégration cohérente des design patterns et l’ajout du diagramme de composants renforcent la compréhension de l’ensemble du système.
Le prototype fonctionnel illustre parfaitement le fonctionnement global et répond à toutes les exigences du cahier des charges.
