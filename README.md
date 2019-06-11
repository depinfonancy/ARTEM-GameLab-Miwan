
 
 Mise à jour post présentation : reste à faire
  - nouvelle idée: Miwan parle comme R2D2 et sur le chemin, il trouve un traducteur -> des sous-titres s'affichent alors dès qu'il parle
  - taille objets pour le level design
  - rendre les elements faciles à réutiliser pour la suite
  - adapter le level design pour que le joueur ait vrmt à chercher les éléments et moins juste à avancer et rentrer dedans
  - ajouter des salles pour le storytelling : libération robots, salles de test...
  - ajouter plus d'éléments à éviter ou à casser pour passer (plateformes, sol à casser en venant du haut)
  - ajouter des ennemis?
  - améliorer les élements à casser: visuel, garder collision?
  - Animer casier/lentille scène 7
  - Animer porte et bande à couper scène 8
  - animer je sais plus quoi scène 9
  - activer la vision nocturne après collision en scène 10
  - rendre les plateformes mouvantes en 11+12+13
  - ajuster les réglages de la caméra sur les scènes de la fin
  - rendre possible le changement de scène vers la gauche
  - ....


Déjà fait:
 - Rampes avec prise de vitesse (voir unity effector pour créer champ de force) camille
 - élements de décor à casser (caisses en bois, placard, etc) guillaume
 - miwan sans bras 
 - grimper à la corde
 - menu (accueil, pause) kou
 - commencer à regarder les scripts 
 - lentille et vision infrarouge (avec shader)
 - jetpack : est ce qu'il a une durée d'utilisation limitée ?
 - musiques et bruitages 
 - assemblage des décors (en reprenant la numérotation du drive): 1-2-3-4  7-8-9 11-12-13-14-15 ok (Camille)

Tâches effectuées :
 - Camille : Effectors, scènes 1-7 et 12-15, changement de scène
 - Noémie : Scenes 10 à 13, vision nocturne (post-processing), lentille, correction bug en 'live' le jour de la présentation
 - Anas : gestions des boutons, menu, sons, 
 - Kou : menus de pause, de départ, éclairage
 - Guillaume : éléments de décors à casser (caisse, placard, ...), script caméra, ajustements dernière minute pour avoir un jeu uniforme et jouable
 - Léo : Intégration des animations, création de l'Animator pour Miwan, scripts PlayerController, Jetpack, Arms pour que Miwan soit affiché comme il faut en fonction de son avancement dans le jeu, affichage de messages d'explications


<<<<<<< HEAD
Notes Noémie: 
 - https://docs.unity3d.com/Packages/com.unity.postprocessing@2.1/manual/Quick-start.html (pack postprocessing) 
 Dans un premier temps: on arrive dans la scène et la vision nocturne est activée
 Dans un second temps: on récupère une lentille et à ce moment là, une touche apparait (pour montrer comment l'activer). Pénétrer dans la scène concernée qui est dans le noir puis activer la lentille. 

