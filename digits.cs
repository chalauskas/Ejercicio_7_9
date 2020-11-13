//This program calculates how many numbers of 1, 2, 3 or more digits are entered by the user until he/she types “end”.

using System;

class digits
{
    static void Main()
    {

	    int oneDigitNumber = 0, twoDigitsNumber = 0, threeDigitsNumber = 0, lotsDigitNumber = 0;
        Console.Write("Insert a number: ");      
        string userNumber = Console.ReadLine();

        while(userNumber != "end")
        {
            int input = Convert.ToInt32(userNumber);
            if(input != 0)
            {
                if(input/10 == 0)
                oneDigitNumber ++;  

                else if (input/100 == 0)
		        twoDigitsNumber ++;  

                else if (input/1000 == 0)
                threeDigitsNumber ++;  

                else
                lotsDigitNumber++; 
            }
        userNumber = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
            oneDigitNumber, twoDigitsNumber, threeDigitsNumber, lotsDigitNumber); 
    }
}


