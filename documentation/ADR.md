# Architecture Decision Records ADR-<NN> — <Choix d’une application Web centralisée pour CanadaWelcome>
**Statut :** Proposed 
**Date :** <2026-01-25>  
**Décideurs :** <Hajar Chobani, Rayane Achoukairi ,Ibrahim Moriba Camara >  
**Contexte projet :** <CanadaWelcome / application d'intégration des nouveaux immigrants >

---

## 1. Contexte
- **Problème / besoin :**Les nouveaux immigrants au Canada font face à des démarches administratives et logistiques complexes, comme obtenir le NAS, la carte de transport,et aussi l'ouverture de compte bancaire et la recherche de logement. Les informations sont réparties sur plusieurs plateformes, ce qui rend le processus d’intégration long et difficile.Aussi des fois les nouveaux immigrants ne save pas tous démarches administratives à faire   . 
- **Contraintes :avoir une application simple et accessible, temps de développement limité , équipe reduite, outils
- **Forces en présence :Simplicité d’utilisation, centraliosation de l'inforamation, réduction du stresse pour les nouveaux immigrants, éviter d'avoir des informations incomplètes ou non à jours

---

## 2. Décision
Nous avons décidé de développer une application Web centralisée appelée CanadaWelcome.

Cette application regroupe dans une seule plateforme les services et informations essentiels à l’intégration des nouveaux immigrants, notamment :

les guides d’intégration
les démarches pour obtenir le NAS
les informations bancaires
les cartes de transport
la recherche de logement
le suivi de progression des démarches

Nous avons choisi une application Web plutôt qu’une application mobile native afin de simplifier le développement, réduire les coûts techniques et permettre un accès rapide à partir de n’importe quel navigateur.
---

## 3. Alternatives considérées
### Option A — siteWeb
- **Avantages : plus facile , moins coûteux, moins de temp pour développement
- **Inconvénients : quand tu quitte le site web tu dois commencer a zero, informations non regroupées, difficile à utiliser

### Option B — Application mobile
- **Avantages : informations regroupées,
- **Inconvénients : temp de développement plus élevé

---

## 4. Justification (Pourquoi cette décision ?)
- <raison 1>Accessibilité
Une application Web peut être utilisée sur ordinateur ou téléphone sans installation, ce qui la rend plus accessible pour les nouveaux immigrants.
- <raison 2>Centralisation
Elle permet de regrouper dans une seule plateforme les informations importantes au lieu d’obliger l’utilisateur à visiter plusieurs sites différents.
- <raison 3>Personnalisation
Grâce à la connexion et à l’inscription, l’utilisateur peut avoir un profil, suivre ses démarches et accéder à un contenu plus adapté à sa situation.

---

## 5. Conséquences
### Positives
Meilleure expérience utilisateur
Données centralisées et organisées
Possibilité de gérer les utilisateurs et les guides
Structure plus claire pour le projet

### Négatives / Risques
Il faut sécuriser les comptes utilisateurs
Dépendance à une base de données
Nécessite plus de logique backend qu’un simple site informatif

### Impact sur l’architecture / le code
_Cette décision implique :

.la création d’un module Authentification
.la gestion d’une base de données MySQL
_la création des entités principales :
Utilisateur
Admin
Guide
Logement
Progression
_l’organisation du projet en couches :
interface utilisateur
logique métier
accès aux données

_Elle influence aussi l’usage de certains patrons de conception

---

## 6. Plan d’implémentation (court)
- [ ] Étape 1 : <Créer la structure de base du projet Web>
- [ ] Étape 2 : <Développer l’inscription et la connexion utilisateur>
- [ ] Étape 3 : <Ajouter la base de données>
- [ ] Etape4 : Ajouter la recherche de logement
- [ ] Étape 6 : Ajouter l’interface administrateur pour gérer les guides
- [ ] Étape 7 : Tester les fonctionnalités principales

---

## 7. Validation
- **Comment vérifier que c’est bon ?**
La décision sera considérée comme valide si :

_l’utilisateur peut s’inscrire et se connecter
_l’utilisateur peut consulter les guides
_l’utilisateur peut rechercher un logement
_l’administrateur peut ajouter, modifier ou supprimer un guide
_les données sont bien enregistrées dans la base de données
_l’application reste simple à utiliser

Critères d’acceptation :
_Temps de réponse acceptable
_Interface claire
_Fonctionnalités principales fonctionnelles
_Prototype exécutable disponible

## 8. Liens
- UML : <Diagramme de cas d’utilisation, diagramme de classes>
- Issue/Tâche : <Développement CanadaWelcome>
- Référence : <doc officiel / cours>
