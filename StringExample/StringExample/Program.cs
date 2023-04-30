using System;
using System.Text;

namespace StringExample
{
    internal class Program
    {
        static void Main(String[] args)
        {
            String s = "We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            String[] strings = s.Split(new char[] { '.', '!', '?' });
            StringBuilder sb = new StringBuilder();

            int i;
            
            foreach (String str in  strings)
            {
                i = -1;
                while (true)
                {
                    i = (str.ToLower()).IndexOf("in", i + 1);
                    if (i >= 0)
                    {
                        if ((i + 2 < str.Length && str[i + 2] == ' ' && i - 1 >= 0 && str[i-1] == ' ') || 
                            (i + 2 == str.Length && i - 1 >= 0 && str[i - 1] == ' ') || 
                            (i - 1 == 0 && i + 2 < str.Length && str[i + 2] == ' ') ||
                            (i == 0 && i + 2 == str.Length))
                        {
                            sb.Append(str.Trim() + ".\n");
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Write(sb.ToString());
        }
    }
}