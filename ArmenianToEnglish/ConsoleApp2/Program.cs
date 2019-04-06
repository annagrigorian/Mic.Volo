using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            
            Console.WriteLine(ToEnglish(text));

            
        }

        static StringBuilder ToEnglish(string word)
        {
            StringBuilder inEnglish = new StringBuilder();

            var lettercollection = word.Select(i => i);

            foreach (var item in lettercollection)
            {
                switch (item)
                {
                    
                    case 'ա':
                        inEnglish.Append("a");
                        break;
                    case 'բ':
                        inEnglish.Append("b");
                        break;
                    case 'գ':
                        inEnglish.Append("g");
                        break;
                    case 'դ':
                        inEnglish.Append("d");
                        break;
                    case 'ե':
                        inEnglish.Append("e");
                        break;
                    case 'զ':
                        inEnglish.Append("z");
                        break;
                    case 'է':
                        inEnglish.Append("e");
                        break;
                    case 'ը':
                        inEnglish.Append("@");
                        break;
                    case 'թ':
                        inEnglish.Append("t");
                        break;
                    case 'ժ':
                        inEnglish.Append("j");
                        break;
                    case 'ի':
                        inEnglish.Append("i");
                        break;
                    case 'լ':
                        inEnglish.Append("l");
                        break;
                    case 'խ':
                        inEnglish.Append("kh");
                        break;
                    case 'ծ':
                        inEnglish.Append("ts");
                        break;
                    case 'կ':
                        inEnglish.Append("k");
                        break;
                    case 'հ':
                        inEnglish.Append("h");
                        break;
                    case 'ձ':
                        inEnglish.Append("dz");
                        break;
                    case 'ղ':
                        inEnglish.Append("gh");
                        break;
                    case 'ճ':
                        inEnglish.Append("tsh");
                        break;
                    case 'մ':
                        inEnglish.Append("m");
                        break;
                    case 'յ':
                        inEnglish.Append("y");
                        break;
                    case 'ն':
                        inEnglish.Append("n");
                        break;
                    case 'շ':
                        inEnglish.Append("sh");
                        break;
                    case 'ո':
                        inEnglish.Append("vo");
                        break;
                    case 'չ':
                        inEnglish.Append("ch");
                        break;
                    case 'պ':
                        inEnglish.Append("p");
                        break;
                    case 'ջ':
                        inEnglish.Append("j");
                        break;
                    case 'ռ':
                        inEnglish.Append("r");
                        break;
                    case 'ս':
                        inEnglish.Append("s");
                        break;
                    case 'վ':
                        inEnglish.Append("v");
                        break;
                    case 'տ':
                        inEnglish.Append("t");
                        break;
                    case 'ր':
                        inEnglish.Append("r");
                        break;
                    case 'ց':
                        inEnglish.Append("c");
                        break;
                    case 'ւ':
                        inEnglish.Append("u");
                        break;
                    case 'փ':
                        inEnglish.Append("p");
                        break;
                    case 'ք':
                        inEnglish.Append("q");
                        break;
                    case 'և':
                        inEnglish.Append("ev");
                        break;
                    case 'օ':
                        inEnglish.Append("o");
                        break;
                    case 'ֆ':
                        inEnglish.Append("f");
                        break;
                    case ' ':
                        inEnglish.Append(' ');
                        break;
                    default:
                        inEnglish.Append(item);
                        break;
                }
            }
            return inEnglish;
        }
    }
    
}
