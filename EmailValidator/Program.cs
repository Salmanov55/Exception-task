using System;
using static EmailValidator.EmailValidator;

namespace EmailValidator
{
    public class EmailValidator
    {
        public class ShortEmailException : Exception
        {
            public ShortEmailException(string message) : base(message)
            {
            }
        }

        public class NotAnEmailAddressException : Exception
        {
            public NotAnEmailAddressException(string message) : base(message)
            {
            }
        }
        public bool Validate(string email)
        {
            if (email.Length < 10)
            {
                throw new ShortEmailException("Email address is too short.");
            }

            if (!email.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAddressException("Invalid email address format.");
            }

            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailValidator = new EmailValidator();

            try
            {
                bool isValid = emailValidator.Validate("ali.salmanov@mail.com");
                Console.WriteLine(isValid);
            }
            catch (ShortEmailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAnEmailAddressException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
