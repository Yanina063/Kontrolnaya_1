// Из имеющегося массива сформировать массив строк, длинна которых меньше или равна 3 символам
string [] array = { "1234", "1567", "-2", "computer science" };

string [] result = array.Where(item => item.Length <= 3).ToArray();

Console.WriteLine("Результат: ");


foreach(string element in result) {
    Console.WriteLine(element);
}


