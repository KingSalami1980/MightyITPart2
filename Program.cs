using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyITPart2
{
    class Program
    {
               /// <summary>
        /// This program prompts a user what it is that they want to validate, and then, based on the selection made, prompt them for the data to validate.
        /// It will then validate the data, and show the result of the validation to the user. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine(@"Welcome to Truth... the validation console app!

                                What would you like to validate today?

                                1 - Email address
                                2 - Credit card number
                                3 - Phone number");

            var k = Console.ReadKey().KeyChar.ToString();
            Console.Clear();
            var s = int.Parse(k); // Get the user's selection. TODO: deal with non-numeric input

            bool IsValid = false;

            IsValid = ValidateInput.Equals(s, IsValid);


            if (IsValid)
                Console.WriteLine("VALID");
            else
                Console.WriteLine("INVALID");

            Console.ReadKey();

        }        
    }

    abstract class ValidateInput
    {
        public int InputToValidate { get; set; }
        public abstract bool IsInputValid();
    }

    class ValidateEmail : ValidateInput
    {
        string inputToValidate = "";
        bool IsValid = true;
        public override bool IsInputValid()
        {
            Console.WriteLine("Enter e-mail address: ");
            inputToValidate = Console.ReadLine();
            if (!inputToValidate.Contains("@"))
            {
                IsValid = false;
            }
            if (inputToValidate.Contains("@") && !inputToValidate.Split('@')[1].Contains("."))
                IsValid = false;

            return IsValid;
        }
    }

    class ValidateCreditCard: ValidateInput
    {
        public override bool IsInputValid()
        {
            return false;
        }
    }

    class ValidatePhone : ValidateInput
    {
        public override bool IsInputValid()
        {
            return false;
        }
    }
}
