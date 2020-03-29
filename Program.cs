using System;

namespace Zadachi_v_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToTry = 3;
            string name = "Конор";
            while (numberToTry > 0)
            {
                System.Console.Write("Угадай имя лучшего легковеса в UFC: ");
                string n = Console.ReadLine();
                if(n.ToLower()==name.ToLower()){
                    System.Console.WriteLine("Вы угадали!!!");
                    break;
                }
                else{
                    numberToTry--;
                    System.Console.WriteLine($"Не угадали. Осталось попыток {numberToTry}");
                    if(numberToTry == 0){
                        System.Console.WriteLine("К сожелению не угадали.");
                    }
                } 
                
            }
            
            
            int a = 5, b = 11;
            int sum = 0;
            for(;a<=b;sum += a++);
            System.Console.WriteLine(sum);
        }
    }
}
