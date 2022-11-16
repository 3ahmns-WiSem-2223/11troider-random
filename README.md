# 11troider-random

## Warum könnte man den Zufall beim Programmieren brauchen?
  Um eine funktion zu programmieren, die bei jedem mal einen anderen ausgang hat.
  
## Was ist der Unterschied zwischen Random aus System bzw. aus UnityEngine?
  Sie basieren beide auf dem gleichen Prinzip, aber man muss system.random jedes mal instanzieren, und Unityengine.Random ist statisch und bereits vorhanden.
  ### System.Random:
      - kann öfters instanziert werden
      - wenn öfters instanziert, wird es nicht von den anderen instanzen beeinflusst
  ### Unityengine.Random:
      - nur eine instanz des generators vorhanden
      - leichter zu benutzen
      - weniger code
      
## Warum ist es sinnvoll den seed zu setzen bei Random?
  weil etwas dann random ist, z.b.: eine zahlenfolge, aber diese zahlenfolge bei jedem object gleich ist. Somit ist die randomness steuerbar.
