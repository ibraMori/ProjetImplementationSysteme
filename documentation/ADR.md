# Architecture Decision Records ADR-<NN> — <Titre de la décision>
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
Nous avons décidé de développer une application centralisée appelée CanadaWelcome
- Nous choisissons une application unique regroupant les services essentiels à l’intégration des nouveaux immigrants.
- Pour faciliter, structurer et accélérer leur intégration à la société canadienne.

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
- <raison 1>
- <raison 2>
- <raison 3>

---

## 5. Conséquences
### Positives
- <...>

### Négatives / Risques
- <...>

### Impact sur l’architecture / le code
- <modules touchés, patterns concernés, refactoring prévu>

---

## 6. Plan d’implémentation (court)
- [ ] Étape 1 : <...>
- [ ] Étape 2 : <...>
- [ ] Étape 3 : <...>

---

## 7. Validation
- **Comment vérifier que c’est bon ?**
  - <tests / métriques / critères d’acceptation>

---

## 8. Liens
- UML : <lien/nom de fichier>
- Issue/Tâche : <lien>
- Référence : <doc officiel / cours>
