#Principiile SOLID#
S- Single responsability principle
O-Open-Close principle
L-Liskov substitution principle
I-Interface segregation principle
D-Dependency inversion principle

#Single responsability principle#
Orice modul sau clasă trebuie să încapsuleze o singură funcționalitate.  O clasă sau funcție, nu ar trebui să rezolve sau sa trateze mai mult decât un singur scop deoarece aceasta ar introduce cuplarea între cele două funcționalități.

#Open-Close principle#
Acest principiu exprimă faptul că o clasă sau o funcție, trebuie să fie deschisă pentru extensie dar închisă pentru modificare. De exemplu, dacă avem o bibliotecă ce conține un set de clase ce trebuie extinse ar fi mai corect dacă am avea inițial un set de clase abstracte. Astfel în loc să modificăm clasele concrete din cadrul bibliotecii, putem extinde clasele abstracte.

#Liskov substitution principle#
Clasele derivate trebuie să fie substituibile pentru clasele lor de bază. Adică funcțiile care folosesc referințe la clase de bază, trebuie să poată manipula într-un mod transparent instanțele claselor derivate din acestea. Așadar clasele derivate trebuie doar să adauge funcționalități noi la clasele de bază, nu să le înlocuiască pe cele existente.

#Interface segregation principle#
Mai multe interfețe specifice sunt mai bune decât o interfață generală. Nici un client nu trebuie forțat să depindă de metode pe care nu le folosește. Numărul de membri din interfață care este vizibil pentru clasele dependente trebuie minimizat. Clasele mari vor implementa mai multe interfețe mai mici care grupează funcțiile după maniera lor de utilizare.

#Dependency inversion principle#
Modulele de nivel arhitectural superior nu trebuie să depindă de cele de nivel inferior. Ambele trebuie să depindă de abstracții care, la rândul lor nu trebuie să depindă de detalii (implementări concrete). Practic detaliile depind de abstracții, nu invers. Dacă această dependență nu este vizibilă în faza de proiectare, atunci ea se construiește.
