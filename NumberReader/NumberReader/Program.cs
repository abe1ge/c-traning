using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReader
{

    class WithString
    {

        Dictionary<string, string> units = new Dictionary<string, string>()
            {
                {"1","one"},{ "2","two"},{ "3","three"},{"4","four"},{"5","five"},{"6","six"},{"7","seven"},{"8","eight"},{"9","nine"}
            };

        Dictionary<string, string> teens = new Dictionary<string, string>()
            {
                {"10","eleven"},{"11","eleven"},{ "12","twelve"},{ "13","threteen"},{"14","fourteen"},{"15","fifteen"},{"16","sixteen"},{"17","seventeen"},{"18","eighteen"},{"19","nineteen"}
            };

        Dictionary<string, string> tens = new Dictionary<string, string>()
            {
                {"2","twenty"},{"3","thirty" },{"4","fourty" },{"5","fifty" },{"6","sixty" },{"7","seventy" },{"8","eighty" },{"9","ninty" }
            };

        public string render(string strnum)
        {
            string answer = "";

            for (int i = strnum.Length; i > 0; i--)
            {
                switch (i)
                {
                        
                    case 2:
                        if (strnum[strnum.Length - i] == '0')
                        {
                            answer += units[strnum[strnum.Length - (i - 1)].ToString()];
                        }
                        else if (strnum[strnum.Length - i] == '1')
                        {
                            answer += teens[strnum[strnum.Length - i].ToString() + strnum[strnum.Length - (i - 1)].ToString()];
                        }
                        else
                        {
                            answer += tens[strnum[strnum.Length - i].ToString()] + " " + units[strnum[strnum.Length - (i - 1)].ToString()];
                        }
                        break;
                    case 3:
                        if (units.ContainsKey(strnum[i - 1].ToString()))
                        {
                            answer += units[strnum[strnum.Length - i].ToString()] + " hundered and ";
                        }
                        break;
                    case 4:
                        if (units.ContainsKey(strnum[i - 1].ToString()))
                        {
                            answer += units[strnum[strnum.Length - i].ToString()] + " thusand ";
                        }
                        break;
                    case 1:
                        if (strnum.Length == 1)
                        {
                            answer += units[strnum[0].ToString()];
                        }
                        break;
                    default:
                        answer += ".";
                        break;
                }
            }
            return answer;
        }

    }
    
    class WithMaths
    {

        public string calculate(int strnum)
        {
            string answer = "";
            int thousand = (strnum / 1000);
            int hundered = (strnum % 1000) / 100;
            int tens = ((strnum % 1000) % 100) / 10;
            int unit = ((strnum % 1000) % 100) % 10;

            if (tens == 1)
            {
                answer = numToStr(thousand) + " thousand " + numToStr(hundered) + " hundred and " + numToStr(10 + unit); 
            }
            else
            {
                answer = numToStr(thousand) + " thousand " + numToStr(hundered) + " hundred and " + numToStr(tens * 10) +" " + numToStr(unit); 
            }
            
            return answer;
        }

        public string numToStr(int strnum)
        {
            string result="";
            switch (strnum)
            {
                case 0: return "";break;
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "threteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                case 20: return "twenty";
                case 30: return "thirty"; 
                case 40: return "fourty";
                case 50: return "fifty";
                case 70: return "seventy";
                case 80: return "eighty";
                case 90: return "ninty";
                default : return ".";
            }
            return result;
                
        }
    }

    class dealException
    {
        public int calculate(int a, int b)
        {
            int c = 0;

            if(b == 5)
            {
                DiviedByFiveEception x = new DiviedByFiveEception();
                throw x;
            }
            else
            {
                c = a / b ;
            }

            return c;
        }
    }

    class DiviedByFiveEception:Exception
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            WithString changestr = new WithString();
            WithMaths changemth = new WithMaths();
            change givechange = new change();

           

            Console.Read();
            while (1 == 1)
            {
                Console.WriteLine("How much did it cost?");
                string scanner = Console.ReadLine();
                
                if (scanner != "exit")
                {
                    Console.WriteLine("How much did the customer give?");
                    double given = Double.Parse(scanner);
                
                    double cost = Double.Parse(Console.ReadLine());


                    Console.WriteLine(givechange.giveChange(Double.Parse(scanner), cost));
                    //Console.WriteLine(changestr.render(scanner);
                    //Console.WriteLine(givechange.(scanner));

                }
                else
                {
                    break;
                }
            }
        }
    }
}
