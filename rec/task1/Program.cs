//Задайте значения м и н.Напишите программу которая выводит все натуральные числа в промежутке.
void ShowNumbers(int m, int n)
{
    if (m == n)
    {
    Console.Write(m);
    return;
    }
    Console.Write(m + " ");
    ShowNumbers(m + 1 , n);
}
ShowNumbers(4, 9);