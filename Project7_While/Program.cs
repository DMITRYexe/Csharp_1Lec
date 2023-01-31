// Работа с циклом "while"
Console.Clear();

int xa = 1, ya = 1, // Указываем координаты вершин треугольника
xb = 1, yb = 30,
xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); // Опираясь на координаты, "рисуем" их
Console.Write("*");

Console.SetCursorPosition(xb, yb);
Console.Write("*");

Console.SetCursorPosition(xc, yc);
Console.Write("*");

int x = xa, y = xb; // Просто вводим новые переменные для дальнейшего кода

int count = 0; // Задаем переменную кол-ва для цикла

while (count < 10000) 
{
  int random = new Random().Next(0, 3); // Задаем рандомную переменную, по которой будет выбираться от какой стороны брать половинку
  if (random == 0)
  {
    x = (x + xa) / 2; // Задаем середины отрезков
    y = (y + ya) / 2;
  }
  if (random == 1)
  {
    x = (x + xb) / 2;
    y = (y + yb) / 2;
  }
   if (random == 2)
  {
    x = (x + xc) / 2;
    y = (y + yc) / 2;
  }
  Console.SetCursorPosition(x, y); //Перемещаем курсор в нужное место
  Console.WriteLine("*");  // Ставим точку
count++; // count = count + 1
}