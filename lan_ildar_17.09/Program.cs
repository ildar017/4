using System;

namespace lan_ildar_17._09
{
	class Program
	{
		static void Main(string[] args)
		{

            // гавно 
			char n5 = 'A';
			Console.WriteLine(n5);

			char n6 = '\x5A';
			Console.WriteLine(n6);

			char n7 = '\u0420';
			Console.WriteLine(n7);

			string hello = "Hello";
			string word = "world";

			object a = 22;
			object b = 3.14;
			object c = "hello code"; 

			string name = "Tom";
			int age = 33;
			bool isEmployed = false;
			double weight = 78.65;

			Console.WriteLine($"Имя: {name}");
			Console.WriteLine($"Возраст: {age}");
			Console.WriteLine($"Вес: {weight}");
			Console.WriteLine($"Работает: {isEmployed}");

			int x = 10;
			int z = x + 12; // 22
			Console.WriteLine(z);

			double x = 10.0;
			double z = x % 4.0;
			Console.WriteLine(z);

			int x1 = 5;
			int z1 = ++x1; // z1=6; x1=6
			Console.WriteLine($"{x1} - {z1}");

			int x2 = 5;
			int z2 = x2++; // z2=5; x2=6
			Console.WriteLine($"{x2} - {z2}");

			int x1 = 5;
			int z1 = --x1; // z1=4; x1=4
			Console.WriteLine($"{x1} - {z1}");

			int x2 = 5;
			int z2 = x2--; // z2=5; x2=4
			Console.WriteLine($"{x2} - {z2}");

			Смешанный набор операций

			int a = 3;
			int b = 5;
			int c = 40;
			int d = c-- - b * a;    // a=3  b=5  c=39  d=25
			Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");

			int a = 3;
			int b = 5;
			int c = 40;
			int d = (c - (--b)) * a;    // a=3  b=4  c=40  d=108
			Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");

			Логическое умножение
			int x1 = 2; //010
			int y1 = 5;//101
			Console.WriteLine(x1 & y1); // выведет 0

			int x2 = 4; //100
			int y2 = 5; //101
			Console.WriteLine(x2 & y2); // выведет 4

			логическое сложение 
			int x1 = 2; //010
			int y1 = 5;//101
			Console.WriteLine(x1 | y1); // выведет 7 - 111
			int x2 = 4; //100
			int y2 = 5;//101
			Console.WriteLine(x2 | y2); // выведет 5 - 101

			логическое исключающее ИЛИ
			int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
			int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
			int encrypt = x ^ key; //Результатом будет число 1001011 или 75
			Console.WriteLine("Зашифрованное число: " + encrypt);

			int decrypt = encrypt ^ key; // Результатом будет исходное число 45
			Console.WriteLine("Расшифрованное число: " + decrypt); 

			Логическое отрицание или инверсия

			int x = 9;
			Console.WriteLine(~x);

			Операция присваивания 
			int a = 10;
			a += 10;        // 20
			Console.WriteLine(a);
			a -= 4;         // 16
			Console.WriteLine(a);
			a *= 2;         // 32
			Console.WriteLine(a);
			a /= 8;         // 4
			Console.WriteLine(a);
			a <<= 4;      // 64
			Console.WriteLine(a);
			a >>= 2;      // 16
			Console.WriteLine(a);

			Преобразование базовых данных типов
			byte a = 4;
			int b = a + 70;
			Console.WriteLine(b);
			byte a = 4;
			byte b = (byte)(a + 70);
			Console.WriteLine(b);

			//Явные и неявные преобразовани

            // ГОВНО
            // ХУЙ
			Console.ReadKey();
		}
	}
}
