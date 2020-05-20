using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hacker : MonoBehaviour
{
    //Global Variables 
    const string menuHint = "You may type menu at anytime";
    int level;
    Screen currentScreen;
    //string userPassword;
    string[] purina = { "food", "toys", "bowl", "puppy", "chow" };
    string[] infinitDiscs = { "katana", "thrasher", "thunderbird", "destroyer", "mantra","luna","aviar","avenger" };
    string[] pentagon = { "lockheed", "raytheon", "mercenaries", "blackwater", "honeywell" };
    string password;
    //Enums
    enum Screen { MainMenu, Password, Win};
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello Hacker_01");
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    // Shows Main Menu
    void ShowMainMenu(string greeting)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Terminal 0047 Boot Complete");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Please Select a target for hacking:");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Press 1 for Purina Dog Chow");
        Terminal.WriteLine("Press 2 for Infinite Discs");
        Terminal.WriteLine("Press 3 for The Pentagon");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter your selection: ");

    }

    void OnUserInput(string input)
    {
        if (input == "menu" || input == "Menu")
        {
            ShowMainMenu("Hello Hacker_01 Glad You're Having Fun");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainManu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            Level(level, input);
        }


    }

    void RunMainManu(string input)
    {

       
        if (input == "1" || input == "2" || input == "3")
        {
            level = System.Convert.ToInt32(input);
            EnterLevel(level);
            
        }
        else if (input == "47" || input == "69" || input == "420")
        {
            Terminal.WriteLine("Please pick a level Alicia");

        }
        else
        {
            Terminal.WriteLine("Please input a number 1-3 and press    Enter");
            Terminal.WriteLine(menuHint +".");
        }
    }

    void EnterLevel(int level)
    {
        if (level == 1)
        {
            password = purina[Random.Range(0, purina.Length)];
        }
        else if (level == 2)
        {
            password = infinitDiscs[Random.Range(0, infinitDiscs.Length)];
        }
        else if (level == 3)
        {
            password = pentagon[Random.Range(0, pentagon.Length)];
        }
        else
        {
            ShowMainMenu("Issues Occured Please Try Again");
        }
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen option: " + level);
        currentScreen = Screen.Password;
        Terminal.WriteLine("Enter the password, hint: " + password.Anagram());

        
       
    }
    void Level(int level, string input)
    {
        if (input == "menu" || input == "Menu")
        {
            ShowMainMenu("Hello Hacker_01 Glad You're Having Fun");
        }
        if (currentScreen == Screen.Password)
        {
            if(input == password)
            {
                Winner(level);
            }
            else
            {
                Terminal.WriteLine("Wrong Password Please Try Again.");
                Terminal.WriteLine(menuHint + " if you getstuck.");
            }
        }
       

    }
    void Winner(int level)
    {
        if (level == 1 || level == 2)
        {
            currentScreen = Screen.Win;
            Terminal.ClearScreen();
            Terminal.WriteLine("Condragulations, You're a winner baby");
            Terminal.WriteLine("You've unlocked this site, way to go   Hacker_01");
            Terminal.WriteLine(@"
                   
 ,o.           8 8
d   bzzzzzzzzza8o8b
 `o'
        ");

            Terminal.WriteLine("Type Menu to go back to the beginning  and try another site!");
        }

        else if(level == 3)
        {
            currentScreen = Screen.Win;
            Terminal.ClearScreen();
            Terminal.WriteLine(@"
    __,______ 
   / __.==--'
  /#(-'
  `-'   ");
            Terminal.WriteLine("Great job Hacker_01 you've infiltrated the Pentagon!  You're unstoppable!");
           

            
        }
        


    }

    //void UserPassword(string input)
    //{
    //    userPassword = input;
    //}
    

   
}
