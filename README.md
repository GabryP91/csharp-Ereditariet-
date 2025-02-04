# csharp-Ereditarietà

1.  Scrivere la classe Lampadina i cui oggetti rappresentano delle lampadine elettriche. Una
    lampadina può essere accesa, spenta o rotta, e mette a disposizione due sole operazioni: stato()
    che restituisce una stringa che indica lo stato corrente della lampadina e click() che ne cambia lo
    stato da accesa a spenta o da spenta a accesa o la rompe. Una lampadina si rompe dopo un
    certo numero di click definito dal fabbricante. La classe deve contenere:
    
      a. Una o più variabili di istanza che descrivano opportunamente lo stato della lampadina
      b. Un opportuno costruttore
      c. I metodi sopra citati
    
    Per testare la classe creare un oggetto della classe Lampadina che ammetta un numero massimo
    di click deciso dall’utente.
    
2.  Scrivere la classe Interruttore i cui oggetti rappresentano degli interruttori. Ogni interruttore è
    collegato a una lampadina (oggetto della classe Lampadina) e ne regola l’accensione e
    spegnimento. La classe deve contenere tutte le variabili d’istanza i costruttori e i metodi ritenuti
    opportuni.

    Per testare la classe creare due interruttori (oggetti della classe Interruttore) entrambi collegati
    alla stessa lampadina (uno stesso oggetto della classe Lampadina) e poi, in maniera iterativa,
    offre all’utente la possibilità di agire su uno dei due interruttori (visualizzando l'esito
    dell’operazione) o di terminare l'esecuzione.

3. Modificare la classe Lampadina in modo che tutte le lampadine condividano l’informazione sulla
   presenza di corrente elettrica nell’impianto. Lo stato di una lampadina quando non c’è corrente
   può essere solo spento o rotto. Per testare la classe, offrire all’utente anche la possibilità di staccare o riattivare la corrente.

4. Scrivere una classe Studente con attributi: nome, cognome, isee e annoCorso, scegliere il tipo
   adatto. Creare due classi figlie, Triennale e Magistrale, e creare un metodo che, accettando in
   input un parametro polimorfo, permetta di calcolare le tasse che lo studente dovrà pagare.
      • Se l’isee è minore di 10mila e lo studente è in corso →500
      • Se l’isee è maggiore di 10 mila ma minore di 30mila e lo studente è in corso →700
      • Se l’isee è maggiore di 30 mila, se lo studente è in corso → 1200
      • Paga il 10 % in più per ogni anno di fuori corso (tutti i casi precedenti), fino ad un massimo di 3 anni fuoricorso, poi la tassa non aumenta più.
      • La magistrale paga il 15% in più per i fuori corso fino ad un massimo di due anni.

   Ad esempio fuori corso di un anno con isee<10 mila=550.
   Creare un array di 5 studenti e passarlo al metodo.
