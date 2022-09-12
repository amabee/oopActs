using GetterSetter;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

public class GetterSetters
{
    static List<UserInfo> getterSetters = new List<UserInfo>();
    public static int Id, choice;
    public static String Name, Email, Password, Username;
    static GetterSetters gs = new GetterSetters();
    public static void Main(String[] args)
    {
        do
        {
            Console.WriteLine("OPTIONS: \n [1] Sign Up \n[2] Login");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: gs.AddUser(); break;
                case 2: LogmeIn(); break;
                case 3: Print(); break;
            }
        }
        while (choice != 4);



    }

    private UserInfo AddUser()
    {
        Console.Write("Enter ID: ");
        Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Email: ");
        Email = Console.ReadLine();
        Console.Write("Enter Username: ");
        Username = Console.ReadLine();
        Console.Write("Generated Password: " + "\n");

        int length = 15;
        Random rdm = new Random();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            sb.Append(Convert.ToChar(rdm.Next(101, 132)));
        }

        string v = sb.ToString();
        Password = v;
        Console.Write(Password +"\n \n");

        UserInfo user = new UserInfo { UserID = Id, User_Name = Name, User_Username = Username, User_Email = Email, User_Password = Password };
        getterSetters.Add(user);

        return user;
    }
    private static void Print()
    {
        foreach(UserInfo users in getterSetters)
        {
            Console.WriteLine("User ID: " + users.UserID
                + "\nUser Name: " + users.User_Name 
                + "\nUser Email: " + users.User_Email
                + "\nUsername: " + users.User_Username
                + "\nUser Password: " + users.User_Password
                + "\n \n");
        }
    }

    private static void LogmeIn()
    { int numOfRetry = 0;
        do
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Username: ");
                Username = Console.ReadLine();
                Console.Write("Enter Password: ");
                Password = Console.ReadLine();
                foreach (UserInfo users in getterSetters)
                {
                    if (users.User_Name.Equals(Username) && users.User_Password.Equals(Password))
                    {
                       
                            Console.WriteLine("Welcome Back! " + "@" + users.User_Username);
                            
                    }
                    else
                    {
                        Console.Write("Invalid Credentials\n\n");
                        numOfRetry++;
                    }
                }

                if (numOfRetry > 2)
                {
                    Console.WriteLine("Too many login attempts, please try again later.");
                    Environment.Exit(0);
                }
            }

        } while (numOfRetry != 3);
    }

    private static void ChangePassword()
    {
        Console.Write("Enter Current Password: ");
        Password = Console.ReadLine();
        Console.Write("Enter new Password: ");
        String newPassword = Console.ReadLine();
        foreach(UserInfo users in getterSetters)
        {
            if (users.User_Password.Equals(Password))
            {
                users.User_Password.Replace(Password, newPassword);
                Console.WriteLine("Successfuly Changed your password. \n Your new password is => " + newPassword);
            }
            else
            {
                Console.Write("Wrong Password, Try Again: ");
            }
        }
    }
}