/*
 * using System.Collections.Generic;
 *  List<T>
 *  Dictionary<TKey, TValue>
 *  Queue<T>
 *  Stack<T>
 */

namespace List_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T>, Dictionary<Key, Value>
            List<string> nomi = new() { "Luca", "Giorgio", "Anna", "Nori", "Alex", "Giulia" };
            Console.WriteLine(nomi.Count); // Numero di elementi.
            nomi.Add("Omar"); // Aggiunge un elemento alla fine
            Console.WriteLine("Il nome selezionato è: " + nomi[3]);
            for (int i = 0; i < nomi.Count; i++)
            {
                Console.WriteLine(nomi[i]);
            }
            Console.WriteLine("==================== Con Remove =======================");
            nomi.Remove("Nori");


            for (int i = 0; i < nomi.Count; i++)
            {
                Console.WriteLine(nomi[i]);
            }
            Console.WriteLine("================= Con RemoveAd =========================");
            nomi.RemoveAt(4); // Rimuove per indice.

            for (int i = 0; i < nomi.Count; i++)
            {
                Console.WriteLine(nomi[i]);
            }

            //Console.WriteLine("Ciclo foreach");
            //foreach (string nome in nomi)
            //{
            //    Console.WriteLine(nome);
            //}

            List<int> numeri = new() { 8, 7, 6, 5, 4, 1, 2, 3 };
            numeri.Remove(3);
            //numeri.Clear(); //Rimuove tutti gli elementi dalla lista (DROP TABLE in SQL Server)

            // Visualizzare i numeri Con foreach
            Console.WriteLine("Numeri nella lista: (con foreach)");
            foreach (int numero in numeri)
            {
                Console.WriteLine(numero);
            }

            numeri.AddRange(new List<int> { 9, 621, 87, 69, 10, 22, 50 }); //Aggiungere più elementi insieme alla lista


            //Controlla se esiste un valore.
            if (numeri.Contains(20))
            {
                Console.WriteLine("Presente");
            }
            Console.WriteLine("==========================================\n");

            // Visualizzare i numeri Con for
            Console.WriteLine("Numeri nella lista (con for):");
            for (int i = 0; i < numeri.Count; i++)
            {
                Console.WriteLine(numeri[i]);
            }
            Console.WriteLine("==========================================\n");



            // IndexOf(), Sort(), Reverse(), Insert(), RemoveAll(), Find(), FindAll()
            int posizione = numeri.IndexOf(40); // Trova la posizione di un elemento, se non lo trova restituisce -1
            Console.WriteLine(posizione);
            Console.WriteLine("==========================================\n");

            numeri.Sort(); // Ordina la lista in ordine crescente 
            foreach (int numero in numeri)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("==========================================\n");
            numeri.Reverse(); // Ordina la lista in ordine decrescente
            foreach (int numero in numeri)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("==========================================\n");

            int maggiore = numeri.Find(n => n > 20); //(👉 n => n > 20 si chiama Lambda Expression); Trova il primo elemento che soddisfa la condizione (n > 20)
            Console.WriteLine(maggiore);
            Console.WriteLine("==========================================\n");

            var grandi = numeri.FindAll(x => x < 40); // Trova tutti gli elementi che soddisfano la condizione (x < 40) e li restituisce in una nuova lista
            foreach (int numero in grandi)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("==========================================\n");

            Console.WriteLine("=====================Metodi Utili per Disctionary<TKey, TValue> =====================\n");
            Dictionary<string, int> scuola = new();
            scuola.Add("Luca", 30);
            scuola.Add("Giorgio", 28);
            scuola.Add("Giulia", 29);

            scuola["Giorgio"] = 50; // Modifica il valore associato alla chiave "Giorgio"

            foreach (var chiave in scuola.Keys)
            {
                Console.WriteLine(chiave);
            }

            Console.WriteLine("================= Stampa chiave e valore ===================\n");
            foreach (var kvp in scuola) // kvp sta per KeyValuePair
            {
                Console.WriteLine($"Nome stuente: {kvp.Key}, Voto: {kvp.Value}");
            }

            // Esercizio:1 Stato
            Console.WriteLine("================= Esercizio:1 ===================\n");
            Dictionary<string, string> stati = new();
            stati.Add("Lombardia", "Milano");
            stati.Add("Lazio", "Roma");
            stati.Add("Campania", "Napoli");
            foreach (var kvp in stati)
            {
                Console.WriteLine($"Regione: {kvp.Key}, Capoluogo: {kvp.Value}");

            }
        }
    }
}
