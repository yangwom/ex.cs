// See https://aka.ms/new-console-template for more information
//Criando o array
int[] myFirstArray;

//instanciando array: 
//array = new tipo[tamanhoDoArray];

// importante é que o tamanho de um Array em C# é imutável, 
// ou seja, assim que a instância de um Array é criada, o seu 
// tamanho não pode ser alterado.
int[,,] multiDimensionalArray1 = new int[2, 3, 3] {
    {{1, 2, 2}, 
    {1, 4, 6}, 
    {1, 2, 3}},
    {{1, 2, 3}, 
    {1 ,4, 5}, 
    {2, 4, 6}}
};

 int[,] fromArrayToTwoDimArray(int[] array, int lines, int columns)
{
    int[,] result = new int[lines, columns];
    for (int i = 0; i < array.Length; i++)
    {
        result[i / lines, i % columns] = array[i];
    }
    return result;
}

Console.WriteLine(multiDimensionalArray1[1, 0, 2] + " vc é 2?");

int[,] multiDimensionalArray = { 
{ 1, 2, 3 }, 
{ 4, 5, 6 } 
};

int[,,] myArray = new int[,,] {
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            },
            {
                { 7, 8, 9 },
                { 10, 11, 12 },
            }
        };
    

myFirstArray = new int[5] { 1, 2, 3, 4, 5};

foreach (int top in multiDimensionalArray)
{
    Console.WriteLine(top + "testando arr");
    // array multidimencional é constituido linha e colunaa 
    Console.WriteLine(multiDimensionalArray[1, 2]);
}


string[] myFirsStringArray1 = new string[] { "Vamo", "que", "vamo", "!" };

foreach (string name in myFirsStringArray1)
{
    Console.WriteLine(name);
}

// Somente instanciamos o array mais externo neste primeiro passo
    // Repare que apenas o primeiro colchetes contém números
    int[][] jaggedArray = new int[4][];

    // Agora precisamos instanciar um novo array para cada posição do array mais externo
    jaggedArray[0] = new int[4] { 6, 6, 6, 6 };
    jaggedArray[1] = new int[3] { 6, 6, 6 };
    jaggedArray[2] = new int[5] { 6, 6, 6, 6, 6 };
    jaggedArray[3] = new int[2] { 6, 6 };

   // int[,,] multiDimensionalArray1 = new int[2, 3, 3];

int[,,] multiDimensionalArray2 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
//Console.WriteLine(multiDimensionalArray2[1, 1, 1]);

// O array jagged precisa ser instanciado em partes. Primeiro instanciamos o array com 3 dimensões
int[][][] jaggedArray3 = new int[6][][];

// Depois vamos instanciar a primeira linha do array, recebendo um novo array jagged de 2 dimensões
jaggedArray3[0] = new int[3][];

// E assim finalmente podemos instanciar a primeira coluna da primeira linha do array com um novo array de 1 dimensão
jaggedArray3[0][0] = new int[4] { 1, 2, 3, 4 };

