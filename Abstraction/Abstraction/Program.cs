using System;

namespace UserApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMedia media = new SocialMedia("Facebook");
            //User[] users = new User[0];
            string opt;
            do
            {
                Console.WriteLine("1. User elave et");
                Console.WriteLine("2. Userlara bax");
                Console.WriteLine("3. Userlar uzerinde axtaris et");
                Console.WriteLine("0. Menudan cix");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        //var user = CreateUser();
                        //Console.WriteLine(user.CreatedAt);
                        //AddUser(ref users, user);

                        media.UserRegister();
                        break;
                    case "2":
                        //ShowUsers(users);

                        media.ShowUsers();
                        break;
                    case "3":
                        string search = Console.ReadLine();
                        //SearchUsers(users, search);

                        var users = media.SearchUsers(search);

                        for (int i = 0; i < users.Length; i++)
                        {
                            Console.WriteLine(users[i].GetInfo());
                        }
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir tekrar secin");
                        break;
                }
            } while (opt != "0");
            

        }

        //static bool CheckPassword(string password)
        //{
        //    if (!string.IsNullOrWhiteSpace(password) && password.Length >= 8 && password.Length <= 25)
        //    {
        //        //return HasDigit(password) && HasLower(password) && HasUpper(password);  

        //        bool hasDigit = false;
        //        bool hasUpper = false;
        //        bool hasLower = false;

        //        for (int i = 0; i < password.Length; i++)
        //        {
        //            if (!hasDigit && char.IsDigit(password[i]))
        //                hasDigit = true;
        //            else if (!hasLower && char.IsLower(password[i]))
        //                hasLower = true;
        //            else if (!hasUpper && char.IsUpper(password[i]))
        //                hasUpper = true;


        //            if (hasUpper && hasLower && hasDigit)
        //                return true;
        //        }
        //    }

        //    return false;
        //}

        //static bool CheckUserName(string username)
        //{
        //    if(!string.IsNullOrWhiteSpace(username) && username.Length >= 6 && username.Length <= 25)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //static User CreateUser()
        //{
        //    string username;
        //    do
        //    {
        //        Console.WriteLine("UserName: ");
        //        username = Console.ReadLine();
        //    } while (!CheckUserName(username));

        //    string password;
        //    do
        //    {
        //        Console.WriteLine("Password: ");
        //        password = Console.ReadLine();
        //    } while (!CheckPassword(password));

        //    User user = new User(username, password);

        //    return user;
        //}

        //static void AddUser(ref User[] users, User user)
        //{
        //    Array.Resize(ref users, users.Length+1);
        //    users[users.Length - 1] = user;
        //}

        //static void ShowUsers(User[] users)
        //{
        //    for (int i = 0; i < users.Length; i++)
        //    {
        //        Console.WriteLine(users[i].GetInfo());
        //    }
        //}

        //static void SearchUsers(User[] users,string search)
        //{
        //    search = search.ToLower();
        //    for (int i = 0; i < users.Length; i++)
        //    {
        //        if (users[i].UserName.ToLower().Contains(search))
        //        {
        //            Console.WriteLine(users[i].GetInfo());
        //        }
        //    }
        //}
    }
}
