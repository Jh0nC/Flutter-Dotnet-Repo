class ArrayList
{
    static void Main(string[] args)
    {
        int[] numList = [32, 764, -243, 0, 132, -67];
        Console.WriteLine();

        String strDefaultList = "Lista de números: ";
        String strBetwListElmt = ", ";

        int listLength = numList.Length;

        // defaul list print

        for (int i = 0; i < listLength; i++)
        {
            if (i == listLength - 1)
            {
                strBetwListElmt = ".\n";
            };
            strDefaultList = strDefaultList + numList[i] + strBetwListElmt;
        }
        Console.WriteLine(strDefaultList);

        // ascendent sorted list print

        String strAscdtSortedList = "Lista de númeron ordenada ascendente: ";
        int[] ascdtSortedList = new int[listLength];

        int minListValue = 0;

        for (int j = 0; j < listLength; j++)
        {

            if (numList[j] < minListValue)
            {
                minListValue = numList[j];
            }

            Console.WriteLine(ascdtSortedList[j]);

        }

        Console.WriteLine(strAscdtSortedList);


    }
}