int[] numbers = new int[10];
Random rnd = new Random();

// preenche o vetor

for (int i = 0; i < numbers.Length; i++) 
{
    numbers[i] = rnd.Next(1, 99);
}

// Imprime vetor desordenado

Console.WriteLine("Lista original:");
for (int i = 0; i < numbers.Length; i++) 
{
    Console.WriteLine(numbers[i]);
}


// Oderna valores
Array.Sort(numbers);

Console.WriteLine("Lista ordenada:");
// Imprime valor ordenado
for (int i = 0; i < numbers.Length; i++) 
{
    Console.WriteLine(numbers[i]);
}
