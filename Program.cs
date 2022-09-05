using System;
using System.Collections;

public class Program
{
    static ArrayList name = new ArrayList();
    static ArrayList age = new ArrayList();
    static ArrayList gender = new ArrayList();
    static ArrayList birthdate = new ArrayList();
    static ArrayList email = new ArrayList();
    static ArrayList usernameSignup = new ArrayList();
    static ArrayList passwordSignup = new ArrayList();
    static String username = "";
    static String pass = "";

    public static void Main()
    {
        mainfunction();

    }
    public static void signup()
    {
        Console.WriteLine("Enter Name: ");
        name.Add(Console.ReadLine());
        Console.WriteLine("Enter Age: ");
        age.Add(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter gender: ");
        gender.Add(Console.ReadLine());
        Console.WriteLine("Enter birthdate: ");
        birthdate.Add(Console.ReadLine());
        Console.WriteLine("Enter Email: ");
        email.Add(Console.ReadLine());
        Console.WriteLine("Enter Username: ");
        usernameSignup.Add(Console.ReadLine());
        Console.WriteLine("Enter Password: ");
        passwordSignup.Add(Console.ReadLine());

        Console.WriteLine("Successfully Registered");
    }

    public static void Login()
    {
        while (true) {
            Console.WriteLine("Please Enter Username");
            Console.WriteLine("Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Password: ");
            pass = Console.ReadLine();

            if (!username.Equals("") || !pass.Equals("")) {
                for (int i = 0; i < usernameSignup.Count; i++)
                {
                    if (username.Equals(usernameSignup[i]) && pass.Equals(passwordSignup[i]))
                    {
                        Console.Write("Welcome back! @"+name[i] + "\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
            }
            else
            {
                continue;
            }
        }
    }

    public static void mainfunction() {
        while (true) {
            Console.WriteLine("Press (s) for signup and (l) for Login");
            char select = Convert.ToChar(Console.ReadLine());

            if (select.Equals(""))
            {
                continue;
            }
            else if (select.Equals("exit"))
            {
                break;
            }
            else {

                switch (select)
                {
                    case 's':
                        signup();
                        break;
                    case 'l':
                        Login();
                        break;
                }
                
            }
        }
    }
}