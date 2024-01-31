# Programmieranleitung:

# Stand 31.01:

## Spawnen

Die Enemys spawnen random an 5 verschiedenen Spawnpunkten (spawn1,2,3…), diese können beliebig verschoben werden, es können mehr spawnpunkte gemacht werden, solange sie im Array spawn points am Gameobject SpawnManager zugewisen werden.
Das Spawnscript zählt die gespawnten enemys und stellt daher die Spawnzeit um. 

## Enemys:

Die Gegner spawnen und gehen durch den Navmeshagent dierekt zum Player. Wenn sie den Player berühren werden sie durch das Lifemanagment cs am Player zerstört und der Player bekommt eins von 3 Leben abgezogen. Wenn der Gegner mit einem Gamwobject mit dem Tag "Bullet" collidiert wird der Gegner mit Shootable cs zertsört und der Score im Scoremanager wird um eins erhöht.

## Player:

Der Player ist nur prfisorisch als Cube drin, später kommt der Vr player rein. Wichtig: er muss den Tag "Player" haben und das script Lifemanagement.

## Camera:

Es gibt eine Kamera vom Player aus und eine von schräg oben für den Pepersghost.

Die Pepersghost kamera rendert den nebel nicht, unter Camera- Rendering - Cullingmask(mixed) kann man einzelne Layer abwählen (Layer können oben rechts zugewisen werden) 

Die Player Kamera (noch nicht programmiert) soll die Gegner nicht rendern, erst wenn sie ganz nahe am Player sind (geht über gleiche Technik)



# Generell:
Es basiert alles auf Vorlagen von Hederers 2. Klassen Projekt.

## Noch nicht Programmiert:
+ Der Score wird gezählt aber noch nicht angezeigt
+ Man brauch ein Interface in dem man den Score und Highscore sieht und retryen kann
+ Der Player darf die Geister nicht sehen, erst in der letzen Sekunde
+ Es kann sein dass das Spiel wegen der Spawntime oder dem Enemy speed zu leicht/schwer ist (werte müssen geändert werden)
+ Es gibt schon ein paar Sounds und Musik, die aber noch nicht in Unity integriert sind

+ Es können gerne jegliche neue Feature oder anpassungen gemacht werden :)
  

