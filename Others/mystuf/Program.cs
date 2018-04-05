// using static System.Console;  
// namespace UseLocalFunctions  
// {  
//     class Program  
//     {  
//         static void Main(string[] args)  
//         {  
//             void Add(int x, int y)  
//             {  
//                 WriteLine($"Sum of {x} and {y} is : {x + y}");  
//             }  
//             void Multiply(int x, int y)  
//             {  
//                 WriteLine($"Multiply of {x} and {y} is : {x * y}");  
//                 Add(30, 10);  
//             }  
//             Add(20, 50);  
//             Multiply(20, 50);  
//         }  
//     }  
// }   
using System;  
using static System.Console;    
class Program {    
    static void Main(string[] args) {    
        string s = "26-Nov-2016";    
        if (DateTime.TryParse(s, out DateTime date)) {    
            WriteLine(date);    
        }    
        WriteLine(date);    
    }  
}    