// See https://aka.ms/new-console-template for more information

namespace FizzBuzz {
    public class FizzBuzzNew {
        public static void Main(String[] args){
            //Part 1 - Hello World
            FizzBuzzNew.PrintMessage();
            //Part 2 - Print 1 to 100
            FizzBuzzNew.PrintNumbers();
        }

        public static void PrintMessage() {
            Console.WriteLine("Hello, World!");
        }
        public static void PrintNumbers() {
            for(var num = 1 ; num <101; num++){
                Console.WriteLine(num);
            }
        }
        
    }
}    