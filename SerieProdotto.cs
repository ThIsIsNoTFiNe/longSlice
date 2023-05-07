using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {    

        int lun = digits.Length;

     if (span <= 0 || span > lun)                           // controlliamo se il numero per il quale dobbiamo dividere la stringa è
                                                            //minore di 0 (invalido), oppure più lungo della stringa inserita(invalido);
    {
        throw new ArgumentException();         
    }

    int ProdottoMassimo = 0;
    for (int i = 0; i <= lun - span; i++)   //scorro tutta la stringa fino alla lunghezza massima della parola - span
    {
        int Prodotto = 1;
        for (int j = i; j < i + span; j++)          //partendo dalla lunghezza di j=i continua a ciclare fino a quando j < i + span;
        {
            Prodotto = Prodotto * (int)Char.GetNumericValue(digits[j]);    //Calcolo il prodotto, prendendo tramite la funzione GetNumericValue della posizione (digits[j]);
                                                                        // e lo trasforma in intero. 
        }
        if (Prodotto > ProdottoMassimo)                               //Controlliamo  tutti i valori, se uno di essi è maggiore, il valore massimo si aggiorna.
        {
            ProdottoMassimo = Prodotto; 
        }
    }
    return ProdottoMassimo;

    }
}