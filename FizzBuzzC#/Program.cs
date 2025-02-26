// See https://aka.ms/new-console-template for more information

using System;

namespace FizzBuzz {
    public class Program {
        public static void Main(string [] args){
             for (int num = 1; num <= 300; num++){
                Console.WriteLine(GetOutput(num));
            }
        }
        public static List<(int, Func<List<string>, List<string>>)> RulesList = new List<(int, Func<List<string>, List<string>>)> (){
            (3, AddToResult("Fizz")),
            (13, AddToResult("Fezz")),
            (5, AddToResult("Buzz")),
            (7, AddToResult("Bang")),
            (11, BongRule),
            (17, ReverseRule)
        };
        public static string GetOutput(int num){
            List<string> output = new List<string> ();
            foreach (var rule in RulesList){
                if (num % rule.Item1 == 0){
                    output = rule.Item2(output);
                }
            }
            if (output.Count > 0){
                return string.Join("", output);
            }
            return num.ToString();
        }
        public static Func<List<string>, List<string>> AddToResult(string text){
            return (output) => {
                output.Add(text);
                return output;
            };
        }
        
        public static List<string> BongRule(List<string> output){
            output.RemoveAll(val => val !="Fezz");
            output.Add("Bong");
            return output;
        }

        public static List<string> ReverseRule(List<string> output){
            output.Reverse();
            return output;
        }
    } 
}