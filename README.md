Programmieranleitung:

Stand 31.01:

Spawnen

Die Enemys spawnen random an 5 verschiedenen Spawnpunkten (spawn1,2,3…), diese können beliebig verschoben werden, es können mehr spawnpunkte gemacht werden, solange sie im Array spawn points am Gameobject SpawnManager zugewisen werden.
Das Spawnscript zählt die gespawnten enemys und stellt daher die Spawnzeit um. 

Enemys:

Die Gegner spawnen und gehen durch den Navmeshagent dierekt zum Player. Wenn sie den Player berühren werden sie durch das Lifemanagment cs am Player zerstört und der Player bekommt eins von 3 Leben abgezogen

