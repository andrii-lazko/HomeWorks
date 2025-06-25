// See https://aka.ms/new-console-template for more information


//дз заняття 4

int inputValue = int.Parse(Console.ReadLine());

bool isPrime = true;

if (inputValue < 2)
{
    isPrime = false;
}
else if (inputValue == 2)
{
    isPrime = true;
}
else if (inputValue % 2 == 0)
{
    isPrime = false;
}
else 
{
    int divisor = 3;
    while(divisor <= Math.Sqrt(inputValue))
    {
        if (inputValue % divisor == 0)
        {
            isPrime = false;
            break;
        }
        divisor += 2;
    }


}

if (isPrime)
{
    Console.WriteLine("The Prime number");
}
else
{
    Console.WriteLine("Not a Prime number");
}







//заняття 4


//int Counter = 1;

//while (true) //нескінченний цикл
//{
//    Console.Write(Counter + " ");
//    Counter++; //відняти від каунтера одиничку і записати в каунтер та сама фігня -- або ++

//if (Counter == 123)
//    {
//        break;
//    }

//}








//cycles

//Console.Write("Enter the message: ");

//var input = Console.ReadLine();
//while (input != "exit")
//{
//    Console.WriteLine("You entered: " + input);

//    Console.Write("Enter the message: ");
//    input = Console.ReadLine();
//}

//Console.Write("The end!");
//Console.ReadLine();





//calculator

//double val1 = double.Parse(Console.ReadLine());

//string strsign = Console.ReadLine();

//double val2 = double.Parse(Console.ReadLine());


//while (strsign != "exit")
//{
//    double res = 0;

//    if (strsign == "+")
//    {
//        res = val1 + val2;
//    }

//    else if (strsign == "-")
//    {
//        res = val1 - val2;
//    }

//    else if (strsign == "*")
//    {
//        res = val1 * val2;
//    }

//    else if (strsign == "/")
//    {
//        res = val1 / val2;
//    }

//    Console.WriteLine("Result: " + res);

//    val1 = double.Parse(Console.ReadLine());

//    strsign = Console.ReadLine();

//    val2 = double.Parse(Console.ReadLine());
//}









//const string defaultName = "Petro";

//var symbol = 'v';
//var flag = true;

//using System.ComponentModel.Design;

//var strvalue = Console.ReadLine();

//var val = Convert.ToInt32(strvalue);

//string signDescription = val > 0 ? "Positive" : "Negative";

//Console.WriteLine("Your number is " + signDescription);






//const int divisor = 1000;

//var condition = val >= 10000 && val <= 99999;

//if (condition)
//{
//    var firstVal = val / 10000; //1

//    var secondVal = (val - (firstVal * 10000)) / divisor; //2

//    var thirdVal = (val - (firstVal * 10000) - (secondVal * divisor)) / 100; ; //3

//    var fourthVal = (val - (firstVal * 10000) - (secondVal * divisor) - (thirdVal * 100)) / 10; //4

//    var fifthVal = val - (firstVal * 10000 + secondVal * divisor + thirdVal * 100 + fourthVal * 10);

//    Console.WriteLine(firstVal);
//    Console.WriteLine(secondVal);
//    Console.WriteLine(thirdVal);
//    Console.WriteLine(fourthVal);
//    Console.WriteLine(fifthVal);
//}
//else   //if (val < 10000 || val > 99999) //if (!condition)
//{
//    Console.WriteLine($"Error. The number {val} not in the range [10000,99999]"); //string interpolation
//}
//Console.ReadLine();








//дз 3 заняття



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


