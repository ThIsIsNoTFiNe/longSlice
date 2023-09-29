# longSlice
L'esercizio ci chiede, una volta inerita una stringa, di calcolre il prodotto più grande per una sua sottostringa contigua, di una lunghezza N prestabilità. <br>
**Nota:** In questo caso il numero inserito sarà chiamato ***digits***, e la lunghezza delle varie sottostringhe si chiamerà ***span***. <br>
**Possibili problematiche:** <br>
Il programma se testato, pultroppo, non riesce a verificare tutti i possibili casi.

# Spiegazione veloce linee di codici complessi presenti nella dimostrazione:

* throw new ArgumentException(); : Genera un'eccezione quando si riscontra qualcosa di sbagliato o impossibile a livello di esercizio.
* Prodotto = Prodotto * (int)Char.GetNumericValue(digits[j]); : In questo caso la funzione  ***int)Char.GetNumericValue(digits[j]);** serve per estrarre il valore numerico del carattere nella posizione ***j*** nella stringa ***digits***. Trasforma anche il tutto in un Int per ottenenere un valore intero.


# Spiegazione del problema passo a passo:
### All'interno, nel file, sono presenti anche dei commenti per comprendere ancora meglio.
Come prima cosa prendiamo il valore inserito come ***span*** contrliamo se è minore di 0 o maggiore della lunghezza (calcolata in precedenza grazie alla funzione .lenght) di ***digit*** e tramite, ***throw new ArgumentException();***, se vero, dichiariamo che ciò non è valido.


```C#
    int lun = digits.Length;

     if (span <= 0 || span > lun) 
    {
        throw new ArgumentException();         
    }

```

Di conseguenza andiamo a inizializzare una variabile di nome ***ProdottoMassimo*** e scorriamo un primo for, partendo da 0, fino ad arrivare alla lunghezza massima di digit-span.<br>
All'interno dell'ultimo for ne creiamo un altro che partendo dalla stessa posizione di quello precedente scorrera finche non otteniamo una nuova sotto stringa.<br>
Allo stesso tempo incrementiamo il valore della variabile prodotto, inizializzata in precedenza uguale a 1 e non 0 perché altrimenti avremmo avuto sempre 0 come risultato, per la quale per ottenere il risultato moltiplichiamo il prodotto stesso per il valore di j estratto tramite la funzione ***(int)Char.GetNumericValue(digits[j]);)***. <br>   
In conclusione mostriamo in uscita il risultato facendo ritornare la variabile ***ProdottoMassimo***.
```c#
int ProdottoMassimo = 0;
    for (int i = 0; i <= lun - span; i++)  
    {
        int Prodotto = 1;
        for (int j = i; j < i + span; j++)          
        {
            Prodotto = Prodotto * (int)Char.GetNumericValue(digits[j]);     
        }
        if (Prodotto > ProdottoMassimo)                               
        {
            ProdottoMassimo = Prodotto;
        }
    }
    return ProdottoMassimo;


```
