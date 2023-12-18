namespace Sample.Module4;

public class StringModifications
{
    public static void FindSubstrings()
    {
        string message = "Find what is (inside the parentheses)";
        int openeingPosition = message.IndexOf("(");
        int closingPosition = message.IndexOf(")");
            
        openeingPosition += 1;
            
        int length = closingPosition - openeingPosition;
        string result = message.Substring(openeingPosition, length);
        Console.WriteLine(result);
            
        string message2 = "What is the value <span>between the tags</span>?";
        
        const string openTag = "<span>";
        const string closeTag = "</span>";
            
        int openingPosition2 = message2.IndexOf(openTag);
        int closingPosition2 = message2.IndexOf(closeTag);

        openingPosition2 += openTag.Length;
            
        int length2 = closingPosition2 - openingPosition2;
        Console.WriteLine(message2.Substring(openingPosition2, length2));
    }

    public static void FindLastSubstring()
    {
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";
        int openingPosition = message.LastIndexOf('(');
        int closingPosition = message.LastIndexOf(')');
        
        openingPosition += 1;
        
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    public static void FindSubstringsComplex()
    {
        string message = "(What if) there are (more than) one (set of parentheses)?";

        /*  Standard iteration technique where you cut
         *  out the original string to find the next
         *  open symbol index.
         */
        
        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            message = message.Substring(closingPosition + 1).TrimStart();
        }
    }

    public static void FindAnySubstringExample()
    {
        string message = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message}");
        char[] openSymbols = ['[', '{', '('];
        int startPosition = 8;
        int openingPosition = message.IndexOfAny(openSymbols);

        Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

        openingPosition = message.IndexOfAny(openSymbols, startPosition);
        Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");
    }

    public static void FindAnySubstring()
    {
        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        char[] openSymbols = ['[', '{', '('];
        
        /*  A slightly different technique for iterating through 
         *  the characters in the string. This time, use the closing 
         *  position of the previous iteration as the starting index for the 
         *  next open symbol. So, you need to initialize the closingPosition 
         *  variable to zero:
         */
        
        int closingPosition = 0;
        
        while (true)
        {
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
            if (openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);

            char matchingSymbol = ' ';
            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);
            // int closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            //message = message.Substring(closingPosition + 1).TrimStart();
        }
    }

    public static void ReplaceSubstrings()
    {
        string data = "12345John Smith          5000  3  ";
        string message = "This--is--ex-amp-le--da-ta";
        string word = "spectacular";
        Console.WriteLine(data);
        Console.WriteLine(message);
        Console.WriteLine(word);
        Console.WriteLine("---------------------------");
            
        // Remove substring
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);
            
        // Replace all occurrences with a new value
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);
            
        int t = word.IndexOf('t');
        int l = word.IndexOf('l');
            
        // Replace first occurrence
        // First approach
        char[] letters = word.ToCharArray();
        letters[t] = 'T';

        word = new string(letters);
        Console.WriteLine(word);

        // Second approach 
        word = word.Remove(l, 1).Insert(l, "LL");
        Console.WriteLine(word);
    }
    public static void ChallengeManipulateString()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here
        const string openSpan = "<span>";
        const string closeSpan = "</span>";
        
        int openingIndex = input.IndexOf(openSpan);
        openingIndex += openSpan.Length;
    
        int closingIndex = input.IndexOf(closeSpan);
        int length = closingIndex - openingIndex;
        quantity = $"Quantity: {input.Substring(openingIndex, length)}";
        
        const string tradeSymbol = "&trade";
        const string regSymbol = "&reg";
        output = input.Replace(tradeSymbol, regSymbol);
        
        const string openDiv = "<div>";
        const string closeDiv = "</div>";
        output = output.Replace(openDiv, "");
        output = output.Replace(closeDiv, "");
        output = $"Output: {output}";

        Console.WriteLine(quantity);
        Console.WriteLine(output);
    }
}