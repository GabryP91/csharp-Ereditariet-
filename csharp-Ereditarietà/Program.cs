/*
     1. 
        Scrivere la classe Lampadina i cui oggetti rappresentano delle lampadine elettriche. Una
        lampadina può essere accesa, spenta o rotta, e mette a disposizione due sole operazioni: stato()
        che restituisce una stringa che indica lo stato corrente della lampadina e click() che ne cambia lo
        stato da accesa a spenta o da spenta a accesa o la rompe. Una lampadina si rompe dopo un
        certo numero di click definito dal fabbricante. La classe deve contenere:

            a. Una o più variabili di istanza che descrivano opportunamente lo stato della lampadina
            b. Un opportuno costruttore
            c. I metodi sopra citati
            Per testare la classe creare un oggetto della classe Lampadina che ammetta un numero massimo
            di click deciso dall’utente.

    2. 
        Scrivere la classe Interruttore i cui oggetti rappresentano degli interruttori. Ogni interruttore è
        collegato a una lampadina (oggetto della classe Lampadina) e ne regola l’accensione e
        spegnimento. La classe deve contenere tutte le variabili d’istanza i costruttori e i metodi ritenuti
        opportuni.
        Per testare la classe creare due interruttori (oggetti della classe Interruttore) entrambi collegati
        alla stessa lampadina (uno stesso oggetto della classe Lampadina) e poi, in maniera iterativa,
        offre all’utente la possibilità di agire su uno dei due interruttori (visualizzando l'esito
        dell’operazione) o di terminare l'esecuzione.

    3. 
        Modificare la classe Lampadina in modo che tutte le lampadine condividano l’informazione sulla
        presenza di corrente elettrica nell’impianto. Lo stato di una lampadina quando non c’è corrente
        può essere solo spento o rotto. 
        Per testare la classe, offrire all’utente anche la possibilità di staccare o riattivare la corrente.

    4. 
        Scrivere una classe Studente con attributi: nome, cognome, isee e annoCorso, scegliere il tipo
        adatto. Creare due classi figlie, Triennale e Magistrale, e creare un metodo che, accettando in
        input un parametro polimorfo, permetta di calcolare le tasse che lo studente dovrà pagare.

            • Se l’isee è minore di 10mila e lo studente è in corso →500
            • Se l’isee è maggiore di 10 mila ma minore di 30mila e lo studente è in corso →700
            • Se l’isee è maggiore di 30 mila, se lo studente è in corso → 1200
            • Paga il 10 % in più per ogni anno di fuori corso (tutti i casi precedenti), fino ad un
            massimo di 3 anni fuoricorso, poi la tassa non aumenta più.
            • La magistrale paga il 15% in più per i fuori corso fino ad un massimo di due anni.
    
        Ad esempio fuori corso di un anno con isee<10 mila=550.
        Creare un array di 5 studenti e passarlo al metodo.
*/
using static csharp_Ereditarietà.Lampadina;


namespace csharp_Ereditarietà
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int scelta;

            while (true) // Loop infinito fino a scelta di uscita
            {
                Console.WriteLine("\n---------------------------------------------------\n");
                Console.WriteLine("Seleziona un esercizio da 1 a 2 oppure digita 0 per uscire:");

                Console.WriteLine("Caso [1]: Creazione istanza classe Lampadina/Interruttore");
                Console.WriteLine("Caso [2]: Creazione array studenti");



                Console.WriteLine("\nFai la tua scelta\n");

                // Controllo input utente
                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                }

                if (scelta == 0)
                {
                    Console.WriteLine("Uscita dal programma...");
                    break; // Esce dal loop e termina il programma
                }

                Console.WriteLine("\n---------------------------------------------------\n");

                switch (scelta)
                {

                    case 1:
                        Console.WriteLine("ESERCIZIO 1-2\n");

                        Console.Write("\nInserisci il numero massimo di click prima che la lampadina si rompa: ");

                        int maxClick;

                        // Controllo input utente
                        while (!int.TryParse(Console.ReadLine(), out maxClick) || maxClick<0)
                        {
                            Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                        }

                        Lampadina lampadina = new Lampadina(maxClick);
                        Interruttore interruttore1 = new Interruttore(lampadina);
                        Interruttore interruttore2 = new Interruttore(lampadina);

                        while (true)
                        {
                            Console.WriteLine("\nScegli un'azione:");
                            Console.WriteLine("[1] Premi Interruttore 1");
                            Console.WriteLine("[2] Premi Interruttore 2");
                            Console.WriteLine("[3] Stacca Corrente");
                            Console.WriteLine("[4] Riattiva Corrente");
                            Console.WriteLine("[5] Controlla stato lampadina");
                            Console.WriteLine("[0] Esci");

                            Console.Write("Scelta: ");

                            int scelta2;

                            // Controllo input utente
                            while (!int.TryParse(Console.ReadLine(), out scelta2))
                            {
                                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                            }

                            if (scelta2 == 0)
                            {
                                Console.WriteLine("Uscita dal programma...");
                                break; // Esce dal loop e termina il programma
                            }

                            switch (scelta2)
                            {
                                case 1:
                                    interruttore1.Premi();
                                    break;
                                case 2:
                                    interruttore2.Premi();
                                    break;
                                case 3:
                                    Lampadina.StaccaCorrente();
                                    break;
                                case 4:
                                    Lampadina.RiattivaCorrente();
                                    break;
                                case 5:
                                    Console.WriteLine(lampadina.Stato);
                                    break;
                                default:
                                    Console.WriteLine("Scelta non valida! Riprova.");
                                    break;
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("ESERCIZIO 3-4\n");

                        Studente[] studenti = new Studente[6];


                        Triennale persona1 = new Triennale("Mario", "Rossi", 9000, 0, new DateTime(2012, 5, 12));
                        Triennale persona2 = new Triennale("Luca", "Neri", 1000, 2, new DateTime(2013, 8, 21));
                        Triennale persona3 = new Triennale("Topolino", "Verdi", 1200, 3, new DateTime(2009, 9, 15));
                        Triennale persona4 = new Triennale("Pippo", "Neri", 20000, 0, new DateTime(2017, 4, 09));
                        Magistrale persona5 = new Magistrale("Anna", "Gialli", 400000, 2, new DateTime(2022, 5, 1));
                        Magistrale persona6 = new Magistrale("Pluto", "Blu", 350000, 4, new DateTime(2022, 9, 18));

                        studenti[0] = persona1;
                        studenti[1] = persona2;
                        studenti[2] = persona3;
                        studenti[3] = persona4;
                        studenti[4] = persona5;
                        studenti[5] = persona6;



                        foreach (Studente studente in studenti)
                        {
                            Console.WriteLine(studente);
                        }


                        break;

                }

            }
        }
    }

    /*
        Scrivere la classe Lampadina i cui oggetti rappresentano delle lampadine elettriche. Una
        lampadina può essere accesa, spenta o rotta, e mette a disposizione due sole operazioni: stato()
        che restituisce una stringa che indica lo stato corrente della lampadina e click() che ne cambia lo
        stato da accesa a spenta o da spenta a accesa o la rompe. Una lampadina si rompe dopo un
        certo numero di click definito dal fabbricante. La classe deve contenere:

            a. Una o più variabili di istanza che descrivano opportunamente lo stato della lampadina
            b. Un opportuno costruttore
            c. I metodi sopra citati

         Per testare la classe creare un oggetto della classe Lampadina che ammetta un numero massimo di click deciso dall’utente.
     
    */

    public class Lampadina
    {
        private string stato; // Stato attuale della lampadina ("Accesa", "Spenta", "Rotta")
        private int maxClick; // Numero massimo di click prima che si rompa
        private int clickEffettuati; // Numero di click effettuati

        private static bool statoCorrente = true; // Stato della corrente (condiviso)


        // Getter e Setter

        // Property per ottenere lo stato attuale della lampadina
        public string Stato { get { return "Stato: " + stato; } set => stato = value; }

        // Property per ottenere lo stato attuale del massimonumero di click
        public int MaxClick { get => maxClick; set => maxClick = value; }

        // Property per ottenere lo stato attuale della corrente
        public static bool StatoCorrente { get => statoCorrente; set => statoCorrente = value; }

        // Costruttore di default
        public Lampadina(){}

        // Costruttore parametrizzato
        public Lampadina(int maxClick)
        {
            Stato = "Spenta";  // La lampadina parte da spenta
            MaxClick = maxClick;
            this.clickEffettuati = 0;
        }
       

        // Metodo per cambiare lo stato della lampadina
        public void Click()
        {
            // Controlla se c'è corrente
            if (statoCorrente == false)
            {
                Console.WriteLine("\nNon c'è corrente.....ripristinare prima la corrente!\n");
            }

            else
            {
                
                if (stato == "Rotta")
                {
                    Console.WriteLine("La lampadina è rotta e non può più essere accesa o spenta.");
                    return;
                }

                clickEffettuati++;

                if (clickEffettuati > maxClick)
                {
                    stato = "Rotta";
                        Console.WriteLine("La lampadina si è rotta dopo troppi click!");
                }

                else
                {    
                    //Controlla lo stato attuale e lo cambia se è Spenta
                    stato = (stato == "Spenta") ? "Accesa" : "Spenta";
                    Console.WriteLine($"Stato della lampadina: {stato}");
                }
            }
        }  
            
        

        // Metodi statici per gestire la corrente elettrica
        public static void StaccaCorrente()
        {
            StatoCorrente = false;
            Console.WriteLine("Corrente staccata!");
        }

        public static void RiattivaCorrente()
        {
            StatoCorrente = true;
            Console.WriteLine("Corrente riattivata!");
        }


    }

        /*
           Scrivere la classe Interruttore i cui oggetti rappresentano degli interruttori. Ogni interruttore è
           collegato a una lampadina (oggetto della classe Lampadina) e ne regola l’accensione e
           spegnimento. La classe deve contenere tutte le variabili d’istanza i costruttori e i metodi ritenuti
           opportuni.
           Per testare la classe creare due interruttori (oggetti della classe Interruttore) entrambi collegati
           alla stessa lampadina (uno stesso oggetto della classe Lampadina) e poi, in maniera iterativa,
           offre all’utente la possibilità di agire su uno dei due interruttori (visualizzando l'esito
           dell’operazione) o di terminare l'esecuzione.

       */

    public class Interruttore
    {
        private Lampadina lampadina;

        // Getter e Setter
        public Lampadina Lampadina { get => lampadina; set => lampadina = value; }

        // Costruttore: l'interruttore è collegato a una lampadina
        public Interruttore(Lampadina lampadina)
        {
            Lampadina = lampadina;
        }

        // Metodo per interagire con la lampadina
        public void Premi()
        {
            Lampadina.Click();
            Console.WriteLine($"Lampadina: {lampadina.Stato}");
        }

    }

    /*
        Scrivere una classe Studente con attributi: nome, cognome, isee e annoCorso, scegliere il tipo
        adatto. Creare due classi figlie, Triennale e Magistrale, e creare un metodo che, accettando in
        input un parametro polimorfo, permetta di calcolare le tasse che lo studente dovrà pagare.

            • Se l’isee è minore di 10mila e lo studente è in corso →500
            • Se l’isee è maggiore di 10 mila ma minore di 30mila e lo studente è in corso →700
            • Se l’isee è maggiore di 30 mila, se lo studente è in corso → 1200
            • Paga il 10 % in più per ogni anno di fuori corso (tutti i casi precedenti), fino ad un
            massimo di 3 anni fuoricorso, poi la tassa non aumenta più.

            • La magistrale paga il 15% in più per i fuori corso fino ad un massimo di due anni.
    
        Ad esempio fuori corso di un anno con isee<10 mila=550.
        Creare un array di 5 studenti e passarlo al metodo.

     */

    public class Studente
    {
        private string nome;
        private string cognome;
        private int isee;
        private int annifuoriCorso;
        private DateTime annoCorso;

      
        // Getter e Setter

        public string Nome { get => nome; set => nome = value; }

        public string Cognome { get => cognome; set => cognome = value; }

        public int Isee { get => isee; set => isee = value; }

        public int AnnifuoriCorso { get => annifuoriCorso; set => annifuoriCorso = value; }

        public DateTime AnnoCorso { get => annoCorso; set => annoCorso = value; }


        // Costruttore di default
        public Studente(){}

        // Costruttore parametrizzato
        public Studente(string nome,string cognome, int isee,int annoFuoriCorso, DateTime annoCorso)
        {
            Nome = nome;
            Cognome = cognome;
            Isee = isee;
            AnnifuoriCorso = annoFuoriCorso;
            AnnoCorso = annoCorso;
        }

        // Metodo virtuale da sovrascrivere nelle classi figlie
        public virtual double CalcolaTasse()
        {
            double tassaBase;

            // Caso in cui l'isee è minore di 10 mila e lo studente è in corso
            if (Isee < 10000 && AnnifuoriCorso == 0)
                tassaBase = 500;
            //Caso in cui l'isee è maggiore di 10 mila ma minore di 30 mila e lo studente è in corso
            else if ((Isee >= 10000 && Isee < 30000) && AnnifuoriCorso == 0)
                tassaBase = 700;
            //Caso in cui l'isee è maggiore di 30 mila e lo studente è in corso
            else if (AnnifuoriCorso == 0)
                tassaBase = 1200;
            else 
            {
                // Calcolo dell'aumento per fuori corso (massimo 3 anni) -> Math.Min restituisce il minimo tra i due valori(x,3)
                int anniConsiderati = Math.Min(AnnifuoriCorso, 3);
                tassaBase = 1200 * (1 + 0.10 * anniConsiderati);
            }

            return tassaBase;
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}, Cognome: {Cognome}, ISEE: {Isee}€,Fuori corso: {AnnifuoriCorso}, Tassa: {CalcolaTasse()} €";
        }

    }

    // Classe Triennale eredita da Studente
    public class Triennale : Studente
    {
        public Triennale(string nome, string cognome, int isee, int annoFuoriCorso, DateTime annoCorso)
            : base(nome, cognome, isee, annoFuoriCorso, annoCorso) { }
    }

    // Classe Magistrale eredita da Studente e ha regole diverse per il fuori corso
    public class Magistrale : Studente
    {
        public Magistrale(string nome, string cognome, int isee, int annoFuoriCorso, DateTime annoCorso)
            : base(nome, cognome, isee, annoFuoriCorso, annoCorso) { }

        public override double CalcolaTasse()
        {
            double tassaBase = base.CalcolaTasse();

            // Per la magistrale, il fuori corso ha un incremento del 15%, massimo per 2 anni
            int anniConsiderati = Math.Min(AnnifuoriCorso, 2);
            double tassaFinale = tassaBase * (1 + 0.15 * anniConsiderati);

            return tassaFinale;
        }
    }
}
