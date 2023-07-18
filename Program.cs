using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CustomValidException : Exception
{
    public CustomValidException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            string uName;
            string eMail;
            string passWord;
            Console.Write("Input your user name: ");
            uName = Console.ReadLine();

            Console.Write("Input your email: ");
            eMail = Console.ReadLine();

            Console.Write("Input your password: ");
            passWord = Console.ReadLine();

            ValidateInput(uName, eMail, passWord);

            Console.WriteLine($"Registeration of User {uName} with Email{eMail} has been registered successfully!!");
            Console.WriteLine("Name: " + uName);
            Console.WriteLine("Email: " + eMail);
            Console.WriteLine("Password: " + passWord);
        }
        catch (CustomValidException cve)
        {
            Console.WriteLine("Error: " + cve.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static void ValidateInput(string name, string email, string password)
    {

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            throw new CustomValidException("All fields are required.");
        }


        if (name.Length < 6)
        {
            throw new CustomValidException("Name must have at least 6 characters.");
        }


        if (password.Length < 8)
        {
            throw new CustomValidException("Password must have at least 8 characters.");
        }
    }
}
