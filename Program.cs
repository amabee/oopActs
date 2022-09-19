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
    static String username, pass;
    static int select;

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
                        Console.Write("Welcome back! @"+usernameSignup[i] + "\n");
                        Console.WriteLine("Name: " + name[i] + "\nAge: " + age[i] + "\nGender: " + 
                            gender[i] + "\nBirthday: " + birthdate[i] + "\nEmail: " + email[i] + "\n \n");
                        whileLoggedIn();
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

    public static void whileLoggedIn()
    {
        while(select != 5)
        {
            Console.WriteLine("[1] : Update Account Password \n[2] : Update Account Username \n[3] Delete Account \n[4] Search User \nChoice: ");
            select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.Write("Enter Old Passoword: ");
                    String oldpass = Console.ReadLine();
                    Console.Write("Enter new Passoword: ");
                    String newpass = Console.ReadLine();
                    for(int i = 0; i<passwordSignup.Count; i++)
                    {
                        if (oldpass.Equals(passwordSignup[i]))
                        {
                            passwordSignup.Remove(passwordSignup[i]);
                            passwordSignup.Add(newpass);
                            Login();
                        }
                        else
                        {
                            Console.Write("Invalid Credentials\n \n");
                        }
                    }
                    break;

                case 2:
                    Console.Write("Enter Old Username: ");
                    username = Console.ReadLine();
                    Console.Write("Enter New Username: ");
                    String newUsername = Console.ReadLine();
                    for (int i = 0; i < usernameSignup.Count; i++)
                    {
                        if (username.Equals(usernameSignup[i]))
                        {
                            usernameSignup.Remove(usernameSignup[i]);
                            usernameSignup.Add(newUsername);
                            Login();
                        }
                        else
                        {
                            Console.Write("Invalid Credentials\n \n");
                        }
                    }
                    break;
                case 3: Console.Write("Do you want to delete this account? Y / n ?: ");
                    char yn = Convert.ToChar(Console.ReadLine());
                    for(int a = 0; a<name.Count; a++)
                    {
                        if(yn == 'y')
                        {
                            name.Clear();
                            usernameSignup.Clear();
                            Login();
                        }
                    }break;
            }
        }
    }


    public static void mainfunction() {
        while (true) {
            Console.WriteLine("[1] : Sign-Up or Create Account \n[2] : Login");
            select = Convert.ToInt32(Console.ReadLine());  
                switch (select)
                {
                    case 1:
                        signup();
                        break;
                    
                    case 2:
                        Login();
                        break;
                    
                    case 3:
                    Environment.Exit(0);
                    break;
                }
                
            }
        }
 }
