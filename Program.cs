// See https://aka.ms/new-console-template for more information

// void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. Potete prendere quella fatta in classe questa mattina

int[]  intArray = {1, 2, 3};

void StampaArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

StampaArray(intArray);

// int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    int result = numero * numero;
    return result;
};

Console.WriteLine(Quadrato(4));


//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] clonedArray = (int[]) array.Clone();

    for (int i = 0; i < clonedArray.Length; i++)
    {
        Console.WriteLine(Quadrato(clonedArray[i]));
    }
    return clonedArray;
}

ElevaArrayAlQuadrato(intArray);

//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int sum = 0;
int sommaElementiArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    Console.WriteLine(sum);
    return sum;
}

sommaElementiArray(intArray);


