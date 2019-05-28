
 
 Mise à jour post présentation : reste à faire
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


Nouvelles tâches :
  - Léo : 
  - Kou : 
  - Noémie : activer vision nocture après collision
  - Camille : changement scène vers gauche
  - Guillaume : 
  - Anas : 


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


Notes _ Léo :
 - attention au Collider qui se décale entre les différentes animations

<<<<<<< HEAD
Notes Noémie: 
 - https://docs.unity3d.com/Packages/com.unity.postprocessing@2.1/manual/Quick-start.html (pack postprocessing) 
 Dans un premier temps: on arrive dans la scène et la vision nocturne est activée
 Dans un second temps: on récupère une lentille et à ce moment là, une touche apparait (pour montrer comment l'activer). Pénétrer dans la scène concernée qui est dans le noir puis activer la lentille. 
 
=======

Branche testsPostProcessingScene10: 
- le post processing s'active quand Miwan tape dans la boîte -> j'aurais aimé avoir une scène initialement totalement noire puis que le PP s'active quand Miwan met sa lentille mais le joueur risque d'être perdu : afficher un message "olala je suis dans le noire, je ne vois rien" 

