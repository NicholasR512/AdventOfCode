// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");

//Day 1
/*string filePath = "input.txt";

string[] lines = File.ReadAllLines(filePath);

int[] firstList = new int[lines.Length];
int[] secondList = new int[lines.Length];

for (int i = 0; i < lines.Length; i++)
{
    var numbers = lines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    firstList[i] = int.Parse(numbers[0]);
    secondList[i] = int.Parse(numbers[1]);
}

//Day 1 Part 1
Array.Sort(firstList);
Array.Sort(secondList);

int count = 0;
for(int i = 0; i < firstList.Length; i++)
{
    if (firstList[i] <= secondList[i])
    {
        count += secondList[i] - firstList[i];
    } else
    {
        count += firstList[i] - secondList[i];
    }
}
Console.WriteLine(count);

//Day 1 Part 2
int total = 0;
for (int i = 0; i < firstList.Length; i++)
{
    int count2 = 0;
    for (int j = 0; j < secondList.Length; j++)
    {
        if(firstList[i] == secondList[j])
        {
            count2++;
        }
 
    }
    total += count2 * firstList[i];
}

Console.WriteLine(total);*/

//Day 2
string filePath = "input2.txt";

string[] lines = File.ReadAllLines(filePath);
int safe = 0;

for (int j = 0; j < lines.Length; j++)
{
    string[] numberStrings = lines[j].Split(' ');
    int[] numbers = Array.ConvertAll(numberStrings, int.Parse);

    bool isSafe = true;
    int badLevelCount = 0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (Math.Abs(numbers[i] - numbers[i + 1]) > 3 || numbers[i] == numbers[i + 1])
        {
            if (badLevelCount == 0)
            {
                badLevelCount++;
            }
            else
            {
                isSafe = false;
                break;
            }
        }
    }

    if (isSafe || (badLevelCount == 1 && ValidateWithSingleRemoval(numbers)))
    {
        safe++;
    }
}

Console.WriteLine($"Number of safe reports: {safe}");

bool ValidateWithSingleRemoval(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        bool isValid = true;

        for (int j = 0; j < numbers.Length - 1; j++)
        {
            if (j == i || j + 1 == i) continue;
            if (Math.Abs(numbers[j] - numbers[j + 1]) > 3 || numbers[j] == numbers[j + 1])
            {
                isValid = false;
                break;
            }
        }

        if (isValid) return true;
    }

    return false;
}
