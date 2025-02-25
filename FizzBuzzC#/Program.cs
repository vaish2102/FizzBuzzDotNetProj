// See https://aka.ms/new-console-template for more information

using System;

namespace FizzBuzz {
    public class FizzBuzzNew {
        static List <string> output = new List <string> ();  
       
        public static void Main(String[] args){
           PrintOutput();
        }

        public static void PrintOutput() {
            for(var num = 1 ; num <101; num++){
                checkNum(num);
            }
            foreach(var elem in output){
             Console.WriteLine(elem);
            } 
        }

      /*  public static void ReverseRule(){
            output.Reverse();
        }*/
        public static void BongRule(){
            output.RemoveAll(val => val !="Fezz");
             output.Add("Bong");
        }

       /* public static void AddToResult(string ruleText){
            output.Add(ruleText);
            Console.WriteLine(output);
        }*/
        public static void checkNum(int num){
           // List <string> result = new List<string> ();
            Dictionary<int,string> rulesList = new Dictionary<int,string>
            {
                { 3, "Fizz" },
                { 13, "Fezz" },
                { 5, "Buzz" },
                { 7, "Bang" }
            };
            foreach(KeyValuePair<int, string> element in rulesList){
                if(num % element.Key == 0){
                    if(num!=11 && num != 17) {
                      output.Add(element.Value);
                    } 
                    else {
                        if(num == 11){
                        BongRule();
                        }
                        if(num == 17){
                             output.Reverse();;
                        }
                    }    
                    
                }
                else {
                     output.Add(num.ToString());
                }
            }
            
        }
        
    }
}    