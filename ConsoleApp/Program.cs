using System.Text;

Console.OutputEncoding = Encoding.UTF8;


#region 1 завдання

Random rnd = new Random();
int[] randomNumbers = new int[10];

for (int i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = rnd.Next(-10, 11);
}
for (int i = 0; i < randomNumbers.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"[{i}] = {randomNumbers[i].ToString()}");
    }
}
#endregion

#region 2 завдання

int sum = 0;
foreach (int number in randomNumbers)
{
    sum += number;
}
if (sum > 0)
{
    Console.WriteLine($"Сума масиву не є від'ємним числом: {sum}");
}
else
{
    Console.WriteLine($"Сума масиву є від'ємним числом: {sum}");
}
#endregion

#region 3 zavdanie

int[,] tabletOfMultiplicatyon = {
    { 1, 1 }, {1, 2}, {1, 3}, {1, 4}, {1, 5}, {1, 6}, {1, 7}, {1, 8}, {1, 9},
    { 2, 2 }, {2, 4}, {2, 6}, {2, 8}, {2, 10}, {2, 16}, {2, 14}, {2, 16}, {2, 18},
    { 3, 3 }, {3, 6}, {3, 9}, {3, 12}, {3, 15}, {3, 18}, {3, 21}, {3, 24}, {3, 27},
    { 4, 4 }, {4, 8}, {4, 12}, {4, 16}, {4, 20}, {4, 24}, {4, 28}, {4, 32}, {4, 36},
    { 5, 1 }, {5, 10}, {5, 15}, {5, 20 }, {5, 25}, {5, 30}, {5, 35}, {5, 40}, {5, 45},
    { 6, 1 }, {6, 12}, {6, 18}, {6, 24}, {6, 30}, {6, 36}, {6, 42}, {6, 48}, {6, 54},
    { 7, 1 }, {7, 14}, {7, 21}, {7, 28}, {7, 35}, {7, 42}, {7, 49}, {7, 56}, {7, 63},
    { 8, 1 }, {8, 16}, {8, 24}, {8, 32}, {8, 40}, {8, 48}, {8, 56}, {8, 64}, {8, 72},
    { 9, 1 }, {9, 18}, {9, 27}, {9, 36}, {9, 45}, {9, 54}, {9, 63}, {9, 72}, {9, 81},
    };
// Це було якесь катування... <( ￣^￣ )>
#endregion

#region 4 завдання
int[,] numbers = new int[5, 5];

int max = numbers[0, 0];
int min = numbers[0, 0];
int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        numbers[i, j] = rnd.Next(-10, 11);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (numbers[i, j] > max)
        {
            max = numbers[i, j];
            maxRow = i;
            maxCol = j;
        }

        if (numbers[i, j] < min)
        {
            min = numbers[i, j];
            minRow = i;
            minCol = j;
        }
    }
}

Console.WriteLine($"\nМаксимальний елемент: {max} на позиції [{maxRow}, {maxCol}]");
Console.WriteLine($"Мінімальний елемент: {min} на позиції [{minRow}, {minCol}]");

#endregion

#region 5 завдання

Console.WriteLine("Введіть к-ть днів, і я порахую що за день це буде!(Візьмемо що сьогодні понеділок): ");
int userNumber = Convert.ToInt16(Console.ReadLine());
int resultIndex = (1 + userNumber) % 7; // 1 - початковий індекс, 7 - к-ть днів в тижні ;D
Week resultday = (Week)resultIndex;
Console.WriteLine($"Через {userNumber} днів буде {resultday}🇬🇧☕💂‍♂️");
enum Week
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
#endregion