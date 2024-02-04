//Вычисление функции Аккермана
int m = Console.WriteLine("Введите m: ");
int n = Console.WriteLine("Введите n: ");

int functionAkkerman = Ask(m, n);

    Console.Write($"Функция Аккермана = {functionAkkerman} ");

    int Ask(int m,int n)

    {
        if (m == 0 ) return n + 1;
        else if (n == 0) return Ask(m - 1, 1);
        else return Ask(m - 1, Ask(m, n -1));
    }

    int InputNumbers(string input)
    {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }