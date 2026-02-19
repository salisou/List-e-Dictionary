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

            List<int> numeri = new() { 1, 2, 3, 4, 5 };
            numeri.Remove(3);
            numeri.Clear(); //Rimuove tutti gli elementi dalla lista (DROP TABLE in SQL Server)

            // Visualizzare i numeri Con foreach
            Console.WriteLine("Numeri nella lista: (con foreach)");
            foreach (int numero in numeri)
            {
                Console.WriteLine(numero);
            }

            numeri.AddRange(new List<int> { 10, 20, 30, 40, 50 }); //Aggiungere più elementi insieme alla lista


            //Controlla se esiste un valore.
            if (numeri.Contains(20))
            {
                Console.WriteLine("Presente");
            }
            // Visualizzare i numeri Con for
            Console.WriteLine("Numeri nella lista (con for):");
            for (int i = 0; i < numeri.Count; i++)
            {
                Console.WriteLine(numeri[i]);
            }


            // IndexOf(), Sort(), Reverse(), Insert(), RemoveAll(), Find(), FindAll()
        }
    }
}
