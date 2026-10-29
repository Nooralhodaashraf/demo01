namespace demo01
            ///XML
            ///<summary>
            ///this is first summary
            /// </summary>
            ///<noor>
            /// </noor>
{

    //C# strongly OOP classes => class Program
    internal class Program //Main class of the program
    {
        static void Main(string[] args) // Entry point of the program
        {
            #region beggining 
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("first Code");

            #endregion
            #region comments 
            //1000 line of code 
            //comments   CTRL + K + C => single line comment for uncomment => CTRL + K + U
            //toggle CTRL + / ظ
            //methods => single line comment 

            /*
             this 
            is 
            a 
            multi line 
            comment
             */

            /*
             * point 1
             * point 2 
             * point 3
             */


            #endregion
            #region this is code exmp1
            //Console.WriteLine("Region 1");

            #endregion
            #region rewrite

            //Console.WriteLine("Region 2");
            #endregion

            #region variables 
            // C# strongly Type Language 

            //int StdAge = 13;
            //String STDName = "Ahmed Ali";
            //double StdGPA = 3.5;
            //char STDGrade = 'A';
            #endregion

            #region naming 
            //naming 
            //int x = 10; => not helpfull 
            //string studentFirstNameOfTheFamily = "Ahmed"; //camel case 1letter of the first wor small and every other word has Capital letter 
            //int studentGrade = 90; //helpfull first letter small camel case
            //string StudentFamilyName = "Ali"; //Pascal case => every first letter of the word is Capital letter

            //String Student_Name = "Ali"; //snake case = Kabab case => every word is separated by underscore and all letters are small 
            #endregion

            #region Input/Output
            //input 
            Console.WriteLine("please enter your name ");
              string FirstName = Console.ReadLine(); //Input from user
            Console.WriteLine($"Hello {FirstName} "); //display output using string interpolation
            Console.WriteLine("Hello "+ FirstName ); //display output using string concatenation

            #endregion



            //assignment 1
            //program that reads from the user his name & Age & subject that he study and display them with 2 ways 


        }



    }
}
