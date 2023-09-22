// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("введите номер дня недели: ");
int nomer = Convert.ToInt32(Console.ReadLine());
if (nomer == 1)
{
    Console.WriteLine("Понедельник");
}
else if (nomer == 2)
{
    Console.WriteLine("Вторник");
}
else if (nomer == 3)
{
    Console.WriteLine("Среда");
}
else if (nomer == 4)
{
    Console.WriteLine("Четверг");
}
else if (nomer == 5)
{
    Console.WriteLine("Пятница");
}
else if (nomer == 6)
{
    Console.WriteLine("Суббота");
}
else if (nomer == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Введите чиссло дня недели (1-7)");
}