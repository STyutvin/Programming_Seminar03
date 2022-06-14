
//Задача 3. Дано трёх значное число N. Определить, есть ли среди его цифр 4 или 7.
Console.Write("Введите трехзначное число: ");
int numeric=Convert.ToInt32(Console.ReadLine());
if (numeric>99 && numeric<1000)
	{
	int number1=numeric/100;
	int number2=numeric/10%10;
	int number3=numeric%10;
	//if (number1==4 && number1!=7 || number2==4 && number2!=7 || number3==4 && number3!=7)
	//	{
	//	Console.WriteLine($"Во введенном числе {numeric} присутствует цифра 4.");
	//	}
	//else if (number1!=4 && number1==7 || number2!=4 && number2==7 || number3!=4 && number3==7)
	//	{
	//	Console.WriteLine($"Во введенном числе {numeric} присутствует цифра 7.");
	//	}
	if (number1==4 || number1==7 && number2==4 || number2==7 && number3==4 || number3==7)
	{
		Console.WriteLine($"Во введенном числе {numeric} присутствует цифра 4 или 7.");
	}	
	else
	{
		Console.WriteLine($"Во введенном числе {numeric} отсутствует цифра 4 или 7.");
	}
    }
    //}
//else
//	{
//	Console.WriteLine("Число должно быть трехзначным.");
//	}