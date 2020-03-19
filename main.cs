using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string username;
    string password;
    string Account;
     List<string> Users = new List<string>();
     
      Console.WriteLine("Hello, are you a new user?");
      string category = Console.ReadLine();
      bool isNewUser = false;
      bool isExistantUser = false;
      if(category == "Yes" || category == "yes"){
        Console.Clear();
        Console.WriteLine("Well, create an acount is very easy\n");
        isNewUser = true;
        isExistantUser = false;
      } else if(category == "No" || category == "no"){
        Console.WriteLine("Oh sorry, welcome back!");
        isNewUser = false;
        isExistantUser = true;
      };
    if (isNewUser == true){
      Console.WriteLine("First of all, we need a username");
      username = Console.ReadLine();
      Console.WriteLine("Then, we need a password");
      password = Console.ReadLine();
      Account = "User: " + username + "\n" + "Password: " + password;
      Users.Add(Account);
    } else if(isNewUser == false && isExistantUser == true){
      Console.WriteLine("Please insert your username");
      username = Console.ReadLine();
      Console.WriteLine("Please insert your password");
      password = Console.ReadLine();
      Account = "User: " + username + "\n" + "Password: " + password;
      if (Users.Contains(Account)){
        Console.WriteLine("You've enter to the matrix");
        Console.WriteLine("\n " + Account);
      }
    }
  }
}
