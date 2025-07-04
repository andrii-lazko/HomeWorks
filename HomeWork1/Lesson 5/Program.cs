
int[,] tableofNumbers = new int[,]
{
    { 1, 2, 3, 7 },
    { 4, 5, 6, 8 }
};

for (int i = 0; i < tableofNumbers.GetLength(0); i++)
{
    for (int j = 0; j < tableofNumbers.GetLength(1); j++)
    {
        Console.Write(tableofNumbers[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();











//const int N = 5;

//int[] numbersToDisplay = new int[N];

//for (int i = 0; i < N; i++)
//{
//    numbersToDisplay[i] = int.Parse(Console.ReadLine());    
//}

//Console.WriteLine("Results:");
//for (int i = 0;i < N; i++)
//{
//    Console.Write(numbersToDisplay[numbersToDisplay.Length - 1 - i ] + " ");
//}

//Console.ReadLine();








//int[] myArray = new int[] { 4, 5, 77, 75, 9, 7, 33};

////for (int i = myArray.Length - 1; i >= 0; i--)
////{
////    Console.WriteLine(myArray[i]);
////}

//foreach (int val in myArray)
//{
//    Console.WriteLine(val);
//}
 

//Console.ReadLine();







//int[] myArray = new int[] { 2, 3, 4, 5, 6, 45, 8 };

//for (int i = 0; i < myArray.Length; i++)
//{
//    Console.WriteLine(myArray[i]);
//}



//const int N = 5;

// int[] myArray = new int[N] {2, 3, 4, 5, 6};

//for (int i = 0; i < N; i++)
//{
//    Console.WriteLine(myArray[i]);
//}

 



 //int index = 0;

//       while (index < N)
//       {
//           Console.WriteLine(myArray[index]);
//           index++;
//       }

//       Console.ReadLine();


