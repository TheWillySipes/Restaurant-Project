using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFierroGroupProject_Ex1
{
    public class SetTableSize
    {

        public static int assignTableNumber { get; set; }

        string rawNumberOfTables = "";
        int numberOfTables;

        string rawAssignTableNumber = "";
        //int assignTableNumber;

        string rawNumberOfPeopleToAssignedTable = "";

        int numberOfPeopleToAssignedTable;
        public void AssignNumberOfTables()
        {
 

            Console.Write("\nEnter Number of Tables: ");
            rawNumberOfTables = Console.ReadLine();

            if (int.TryParse(rawNumberOfTables, out numberOfTables))
            {
                // True: numberOfTables is numeric, Parsing is good.
                //tryAgain = false;
            }
            else
            {
                // False: numberOfTables is not numeric, Parsing is bad.
                //tryAgain = true;
                Console.WriteLine("\nThe value given for Number of Tables is NOT an integer.  Please try again");
            }
        }

        public void AssignTableNumber()
        {


            Console.Write("\nAssign Table Number: ");
            rawAssignTableNumber = Console.ReadLine();
            if (int.TryParse(rawAssignTableNumber, out assignTableNumber))
            {
                // True: assignTableNumber is numeric, Parsing is good.
                //tryAgain = false;
            }
            else
            {
                // False: assignTableNumber is not numeric, Parsing is bad.
                //tryAgain = true;
                Console.WriteLine("\nThe value given for Assigned Table Number is NOT an integer.  Please try again");
            }

            Console.ReadKey();
        }


        public void AssignNumberOfSeatsToTable(int assignTableNumber)
        {

            Console.Write("\nTable: {0} ", assignTableNumber +
                          " Enter number of people for this assigned table: ");
            rawNumberOfPeopleToAssignedTable = Console.ReadLine();
            if (int.TryParse(rawNumberOfPeopleToAssignedTable, out numberOfPeopleToAssignedTable))
            {
                // True: numberOfPeopleToAssignedTable is numeric, Parsing is good.
                //tryAgain = false;
            }
            else
            {
                // False: numberOfPeopleToAssignedTable is not numeric, Parsing is bad.
                //tryAgain = true;
                Console.WriteLine("\nThe value given for Number of People to Assigned Table Number is NOT an integer.  Please try again");
            }
            Console.ReadKey();
        }
    }
}
