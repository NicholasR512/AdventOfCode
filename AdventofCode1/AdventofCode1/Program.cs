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
/* string filePath = "input2.txt";

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
            badIndex = i - 1;
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
Console.WriteLine(count); */

//Day 3
/* string filePath = "input3.txt"; 
string content = File.ReadAllText(filePath);

long totalSum = 0;
int index = 0;
bool isMultiplicationEnabled = true; 


while (index < content.Length)
{
    if (index + 3 < content.Length &&
        content[index] == 'd' &&
        content[index + 1] == 'o' &&
        content[index + 2] == '(' &&
        content[index + 3] == ')')
    {
        isMultiplicationEnabled = true; 
        index += 4; 
    }

    else if (index + 6 < content.Length &&
             content[index] == 'd' &&
             content[index + 1] == 'o' &&
             content[index + 2] == 'n' &&
             (content[index + 3] == '\'' || content[index + 3] == '’') && 
             content[index + 4] == 't' &&
             content[index + 5] == '(' && content[index + 6] == ')')
    {
        isMultiplicationEnabled = false; 
        index += 6; 
    }
    else if (index + 3 < content.Length &&
             content[index] == 'm' &&
             content[index + 1] == 'u' &&
             content[index + 2] == 'l' &&
             content[index + 3] == '(')
    {
        index += 4; 


        string firstNumber = "";
        while (index < content.Length && char.IsDigit(content[index]))
        {
            firstNumber += content[index];
            index++;
        }


        if (index < content.Length && content[index] == ',')
        {
            index++; 

            string secondNumber = "";
            while (index < content.Length && char.IsDigit(content[index]))
            {
                secondNumber += content[index];
                index++;
            }

            if (index < content.Length && content[index] == ')')
            {
                index++; 

                if (int.TryParse(firstNumber, out int x) && int.TryParse(secondNumber, out int y))
                {
                    if (isMultiplicationEnabled)
                    {
                        totalSum += x * y;
                    }
                }
            }
        }
    }
    else
    {
        index++;
    }
}


Console.WriteLine(totalSum); */

