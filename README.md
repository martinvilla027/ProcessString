# ProcessString
Process String Algorithm

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
