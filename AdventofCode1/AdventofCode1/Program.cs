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
int count = 0;

for (int j = 0; j < lines.Length; j++)
{
    string[] numberStrings = lines[j].Split(' ');
    int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
    bool isIncreasing = false;
    bool isDecreasing = false;
    bool isSafe = true;
    int badIndex = 0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (numbers[i] - numbers[i + 1] > 0 && (Math.Abs(numbers[i] - numbers[i + 1]) < 4)) {
            isDecreasing = true;
        } else if (numbers[i] - numbers[i + 1] < 0 && (Math.Abs(numbers[i] - numbers[i + 1]) < 4))
        {
            isIncreasing = true;
        } else {
            isSafe = false;
            badIndex = i;
            break;
        }

        if (isDecreasing == isIncreasing) {
            isSafe = false;
            badIndex = i;
            break;
        }

    }
    if (isSafe) {
        count++;
    } else
    {
        isIncreasing = false;
        isDecreasing = false;
        isSafe = true;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if(i == badIndex - 1)
            {
                if (numbers[i] - numbers[i + 2] > 0 && (Math.Abs(numbers[i] - numbers[i + 2]) < 4))
                {
                    isDecreasing = true;
                }
                else if (numbers[i] - numbers[i + 2] < 0 && (Math.Abs(numbers[i] - numbers[i + 2]) < 4))
                {
                    isIncreasing = true;
                }
                else
                {
                    isSafe = false;
                    break;
                }
            } else if (i == badIndex)
            {
                continue;
            } else
            {
                if (numbers[i] - numbers[i + 1] > 0 && (Math.Abs(numbers[i] - numbers[i + 1]) < 4))
                {
                    isDecreasing = true;
                }
                else if (numbers[i] - numbers[i + 1] < 0 && (Math.Abs(numbers[i] - numbers[i + 1]) < 4))
                {
                    isIncreasing = true;
                }
                else
                {
                    isSafe = false;
                    break;
                }
            }

            if (isDecreasing == isIncreasing)
            {
                isSafe = false;
                break;
            }

        }
        if (isSafe) { count++; }
    }
}
Console.WriteLine(count);
