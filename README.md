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
  
## Was macht Random.Range:
  Mit random.range kann man angeben, in welchen bereich ein random wert generiert werden sollte.
  
## Was ist Random.value, Random.insideUnitSphere, Random.ColorHSV?
  ### Random.value:
      - Random.value erstellt einen zufällig generierten float wert.
  ### Random.insideUnitSphere:
      - Random.insideUnitSphere sucht einen zufälligen punkt in einem umkreis aus. Der Umkreis muss deklariert werden.
  ### Random.ColorHSV:
      - Random.ColorHSV erstellt einen zufälligen Farbwert. Die Parameter für Hue, Saturation, Value und Alpha müssen in float werten angegeben werden.

