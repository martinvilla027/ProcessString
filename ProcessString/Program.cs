using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    /*
        There is a string "sdfgabcwetrrytruyrtuabcpotre!@#abcprtort" - see above.
        The task is to implement the following method:

        public Dictionary<string,string> processString(String inputStr, String separator);

        The result need to contain the following keys:
        Count : count all substrings (itemstrings)  infront of which there is a separator string (if xxx is the string and A is the separator here: xxxAxxxAxxxAxxx, you need to return 3);
        prefix : if any string exists before the first separator, please provide the text
        sortedItems : a string with all itemstrings concatenated in alphabetical order
        evenChars : a string with concatenated all even indexed chars (2,4,6,8,10th)
		
		notes: 
			1. if there is no separator found in input string then the whole inputString is counted as 1 itemString 
			2. zero length strings should not be includded in count
			3. prefix should not be includded in itemstrings 
			4. prefix schould not be includded in count
			5. itemstrings schould be displayed with space (" ") between each of them in the output
		
		implement all results display inside Main method in following format:
		Count: some number
		Prefix: some string
		sortedItems: some string
		evenChars: some string
		
		Example output when executed with inputString = "abcdefSEPgabcwetSEPsdsSEPdsfgSEPfro",separator = "SEP"));
		
		Count: 4
		Prefix: abcdef
		sortedItems: dsfg fro gabcwet sds
		evenChars: aceSPaceSPdSPsgEfo

        */

    public static void Main()
    {
        string inputString = "sdfgabcwetrrytruyrtuabcpotre!@#abcprtort";
        var resultList = new List<Dictionary<string, string>>();
        resultList.Add(processString(inputString, "abc"));
        resultList.Add(processString(inputString, "s"));
        resultList.Add(processString(inputString, "r"));
        resultList.Add(processString(inputString, "zi"));
        resultList.Add(processString("abcdefSEPgabcwetSEPsdsSEPdsfgSEPfro", "SEP"));
        /*
		implement all results display here 
		*/

    }


    public static Dictionary<string, string> processString(String inputStr, String separator)
    {

        Dictionary<string, string> result = new Dictionary<string, string>();

        int itemStringsCount = 0;
        var separatorCount = Regex.Matches(inputStr, separator).Count;

        // If there is no separator found in input string then the whole inputString is counted as 1 itemString 
        if (separatorCount == 0)
        {
            itemStringsCount = 1;
            return result;
        }

        var prefixFlag = false;
        var prefixIndex = 0;

        // Ensuring there is a prefix
        try
        {
            prefixIndex = Regex.Matches(inputStr, separator).First().Index;
        }
        catch (Exception)
        {
            prefixFlag = true;
            Console.WriteLine("There is no Prefix");
        }

        List<string> splitedString = Regex.Split(inputStr, separator).ToList();

        // Zero length strings should not be includded in count
        if (splitedString.Contains(""))
        {
            splitedString.Remove("");
        }

        var prefix = string.Empty;

        // Prefix should not be includded in itemstrings
        if (!prefixFlag && prefixIndex != 0)
        {
            prefix = splitedString[0];
            splitedString.RemoveAt(0);
        }

        // Sorting alphabetically
        splitedString.Sort();

        // Setting item strings count value
        itemStringsCount = splitedString.Count;

        var sortedItems = string.Empty;
        foreach (string item in splitedString)
        {
            sortedItems += item + " ";
        }

        // Getting all even indexed chars
        StringBuilder evenChars = new StringBuilder();
        for (int i = 0; i < inputStr.Length; i += 2)
        {
            evenChars.Append(inputStr[i]);
        }

        Console.WriteLine("Count: " + itemStringsCount);
        Console.ReadLine();
        Console.WriteLine("Prefix: " + prefix);
        Console.ReadLine();
        Console.WriteLine("sortedItems: " + sortedItems);
        Console.ReadLine();
        Console.WriteLine("evenChars: " + evenChars.ToString());

        return result;
    }
}

