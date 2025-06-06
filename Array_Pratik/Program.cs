
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(i+1 + ". sayıyı giriniz:");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Girdiğiniz sayılar:");

foreach  (int number in numbers)
    Console.WriteLine(number);

Console.WriteLine("11. sayıyı giriniz");
int eleven = int.Parse(Console.ReadLine());

int[] newNumbers = new int[numbers.Length + 1];
for (int i = 0; i < numbers.Length; i++)
{
    newNumbers[i] = numbers[i];
}
newNumbers[newNumbers.Length - 1] = eleven;

Array.Sort(newNumbers);
Array.Reverse(newNumbers);

Console.WriteLine("Dizinin büyükten küçüğe sıralanmış hali: ");

foreach (int number in newNumbers)
    Console.WriteLine(number);




