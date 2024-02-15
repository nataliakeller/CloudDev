string path = @"c:\temp\Text.txt";

string readText = File.ReadAllText(path);

string[]? splitText = readText.Split(' ');
int bigLength = splitText[0].Length;
string bigWord = splitText[0];


Console.WriteLine(splitText.Length + 1 + " Words");

for (int i = 0; i < splitText.Length; i++)
{
    if (splitText[i].Length >= bigLength)
    {
        bigLength = splitText[i].Length;
        bigWord = splitText[i];
    }
}

Console.WriteLine($"\nThe biggest word has {bigLength} characters \nand the biggest word is: {bigWord}");
