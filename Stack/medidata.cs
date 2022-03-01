using System.Collections.Generic;
using System.Linq;
using System;

class Result
{
    static void Main()
    {
        string s = "1048575 DUP +";

        var output = method(s);

        Console.WriteLine(output);

    }

    static int method(string S)
    {
        int limt = Convert.ToInt32((Math.Pow(2, 20) - 1));
        string[] data = S.Split(' ');
        try
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case "+":
                        int plus = stack.Pop() + stack.Pop();
                        if (plus > limt || plus < 0)
                            return -1;
                        stack.Push(plus);
                        break;
                    case "-":
                          int sub = stack.Pop() - stack.Pop();
                        if (sub > limt || sub < 0)
                            return -1;
                        stack.Push(sub);
                        break;
                    case "DUP":
                        int tmp = stack.Pop();
                        stack.Push(tmp);
                        stack.Push(tmp);
                        break;
                    case "POP":
                        stack.Pop();
                        break;
                    default:
                        int itemToAdd = Convert.ToInt32(data[i].ToString());
                        if (itemToAdd > limt)
                            return -1;
                        stack.Push(itemToAdd);
                        break;
                }
            }
            if (stack.First() > limt)
                return -1;
            return stack.First();
        }
        catch
        {
            return -1;
        }
    }
}
