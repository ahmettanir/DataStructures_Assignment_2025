using System;
using System.Collections.Generic;

class ShuntingYard {
    static void Main() {
        string infix = "a+b*(c^d-e)";
        Console.WriteLine($"Infix Expression: {infix}");
        Console.WriteLine($"Postfix Expression: {InfixToPostfix(infix)}");
    }

    static string InfixToPostfix(string exp) {
        string result = "";
        Stack<char> stack = new Stack<char>();

        foreach (char c in exp) {
            // Eger karakter harf veya rakamsa direkt sonuca ekle
            if (char.IsLetterOrDigit(c))
                result += c;
            // Eger '(' ise stack'e at
            else if (c == '(')
                stack.Push(c);
            // Eger ')' ise '(' gorene kadar stack'ten cikar
            else if (c == ')') {
                while (stack.Count > 0 && stack.Peek() != '(')
                    result += stack.Pop();
                stack.Pop();
            }
            // Operator ise oncelige gore islem yap
            else {
                while (stack.Count > 0 && Priority(c) <= Priority(stack.Peek()))
                    result += stack.Pop();
                stack.Push(c);
            }
        }
        // Stack'te kalanlari bosalt
        while (stack.Count > 0) result += stack.Pop();
        return result;
    }

    static int Priority(char c) {
        if (c == '^') return 3;
        if (c == '*' || c == '/') return 2;
        if (c == '+' || c == '-') return 1;
        return -1;
    }
}
