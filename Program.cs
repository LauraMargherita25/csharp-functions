// See https://aka.ms/new-console-template for more information

int[] intArray = {2, 6, 7, 5, 3, 9};
int[] arreyAlQuadrato = ElevaArrayAlQuadrato(intArray);

// void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array
void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

// int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero)
{
    int result = numero * numero;
    return result;
};

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! 
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] clonedArray = (int[])array.Clone(); // senza conversione esplicita array.Clone() torna un oggetto

    for (int i = 0; i < clonedArray.Length; i++)
    {
        clonedArray[i] = Quadrato(clonedArray[i]);
    }

    return clonedArray;
}

//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int sommaElementiArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}


Console.Write("Questi sono i tuoi numeri: ");
StampaArray(intArray);

Console.Write("I tuoi numeri elevati al quadrato: ");
StampaArray(arreyAlQuadrato);

Console.WriteLine("La somma dei tuoi numeri: {0}",sommaElementiArray(intArray));

Console.WriteLine("La somma dei tuoi numeri elevati al quadrato: {0}", sommaElementiArray(arreyAlQuadrato));
