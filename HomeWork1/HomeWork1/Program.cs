// See https://aka.ms/new-console-template for more information

//������� 4


//const string defaultName = "Petro";

//var symbol = 'v';
//var flag = true;

const int divisor = 1000;
var strvalue = Console.ReadLine();

var val = Convert.ToInt32(strvalue);

var condition = val >= 10000 && val <= 99999;

if (condition);
{
    var firstVal = val / 10000; //1

    var secondVal = (val - (firstVal * 10000)) / divisor; //2

    var thirdVal = (val - (firstVal * 10000) - (secondVal * divisor)) / 100; ; //3

    var fourthVal = (val - (firstVal * 10000) - (secondVal * divisor) - (thirdVal * 100)) / 10; //4

    var fifthVal = val - (firstVal * 10000 + secondVal * divisor + thirdVal * 100 + fourthVal * 10);

    Console.WriteLine(firstVal);
    Console.WriteLine(secondVal);
    Console.WriteLine(thirdVal);
    Console.WriteLine(fourthVal);
    Console.WriteLine(fifthVal);
}
if (val < 10000 || val > 99999)
{
    Console.WriteLine($"Error. The number {val} not in the range [10000,99999]");
}
Console.ReadLine();



//�� 3 �������



//int val = 12345;

//int firstVal = val / 10000; //1

//int secondVal = (val  - (firstVal * 10000)) / 1000; //2

//int thirdVal = (val - (firstVal * 10000) - (secondVal * 1000)) / 100; ; //3

//int fourthVal = (val - (firstVal * 10000) - (secondVal * 1000) - (thirdVal * 100)) / 10; //4

//int fifthVal = val - (firstVal * 10000 + secondVal * 1000 + thirdVal * 100 + fourthVal * 10);

//Console.WriteLine(firstVal); 
//Console.WriteLine(secondVal); 
//Console.WriteLine(thirdVal);  
//Console.WriteLine(fourthVal); 
//Console.WriteLine(fifthVal);






//double val = 12345.0;

//char c = 'A';

//bool b = val > 15;
//bool d = val == 12;
//bool e = 19 != 13;

//Console.WriteLine(b);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(89 == 6);

//Console.WriteLine(val / 10000);









//Console.WriteLine("One");

//Console.ReadLine();

//Console.WriteLine("Two");

//Console.ReadLine();

//Console.WriteLine("Three");

//Console.WriteLine("Four");

//Console.ReadLine();

//Console.WriteLine("$$$_____$$$$$$$_$$$$$$$_$$$_______$$$_$$$$$$$$$$");
//Console.WriteLine("$$$____$$$____$$$____$$$_$$$_____$$$__$$$_______");
//Console.WriteLine("$$$____$$$_____$_____$$$_$$$_____$$$__$$$_______");
//Console.WriteLine("$$$_____$$$_________$$$___$$$___$$$___$$$$$$$$__");
//Console.WriteLine("$$$______$$$_______$$$_____$$$_$$$____$$$_______");
//Console.WriteLine("$$$_______$$$_____$$$______$$$_$$$____$$$_______");
//Console.WriteLine("$$$$$$$$$___$$$$$$$_________$$$$$_____$$$$$$$$$$");

//Console.ReadLine();

//string name = "Andrii";
//string lastname = "Lazko";

//Console.WriteLine("Hello " + name + " " + lastname);

//Console.ReadLine();


