

// ДОМАШНЕЕ ЗАДАНИЕ К 2 СЕМИНАРУ
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// int Metod (int number)
// {

//      if ( number < -999 || number > 999)


//           {
//                Console.WriteLine("введите трехзначное число  "); 
          

//           }

//      int num = number / 10;           
//      int dec = num % 10;       
//                                    //     не пойму почему когда вводишь число где больше 3 х знаков терминал выдает
//                                    //    как и должен "введите 3 х значное число" но и одновременно считает его 
     
//      return dec ; 


// }
    
// Console.WriteLine("введите число  ");
// int num_ent = Convert.ToInt32(Console.ReadLine());

// int res = Metod(num_ent);
// Console.WriteLine($"Result: {res}"); 


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



// void Func(int number)                                             
// {
//     if ( number >= 100 ^ number <= -100)            
                                                    
//     {
//         int new_number = number;
//         int oper = 0;

//             while ( new_number >= 1000 ^ new_number <= -1000 )
//                 {
//                     new_number = new_number / 10;
//                 }
//         oper = new_number % 10;
//         if ( oper < 0 ) oper = oper * (-1);   
//         Console.WriteLine($"Third character of the entered value: {oper}");

//     }                                             
// }
// Console.WriteLine("Enter the number: ");
// int number_entered = Convert.ToInt32(Console.ReadLine());
// Func(number_entered);





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("start programm, введите число ");  
// int B = Convert.ToInt32(Console.ReadLine());


// if (B > 5 && B < 8 ) 
// Console.WriteLine($" {B}  выходной день " );

// else 

// Console.WriteLine($"{B}  будний  день " );
