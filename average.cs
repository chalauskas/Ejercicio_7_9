// This program calculates the average of a set of marks, until the user types “end”.

using System;

public class Average
{
	public static void Main()
	{
		double sumOfMarks=0, marksInNumber, numberOfImputs=0, averageMark;
		string finishProgram;

		Console.Write("Insert a mark: ");
		finishProgram = Console.ReadLine();		
		
		while(finishProgram != "end")
		{  
			marksInNumber=Convert.ToDouble();

			numberOfImputs++;   
			sumOfMarks += marksInNumber;  

			Console.Write("Insert a mark: ");
			finishProgram=Console.ReadLine();
		}
		
		if(numberOfImputs != 0)
		{
			averageMark=a/numberOfImputs; 
			Console.WriteLine("The average is {0}.",averageMark);
		}
	}
}