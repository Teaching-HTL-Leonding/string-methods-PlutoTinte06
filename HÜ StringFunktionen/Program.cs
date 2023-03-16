string input = Console.ReadLine()!;
char j = char.Parse(Console.ReadLine()!);
int index = 0;

bool Contains(string input, char j)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == j) return true;

    }

    return false;
}

Console.WriteLine(Contains(input, j));

int IndexOf(string input, char j, int index)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == j) { index = i; break; }
        else if (!(Contains(input, j))) {index = -1;}

    }

    return index;
}

Console.WriteLine(IndexOf(input, j, index));

int LastIndexOf(string input, char j, int index)
{
     for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == j) { index = i; }
        else if (!(Contains(input, j))) {index = -1;}

    }

    return index;
}

Console.WriteLine(LastIndexOf(input, j, index));
