using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hacker : MonoBehaviour
{
    //Global Variables 
    int level;
    Screen currentScreen;
    //string userPassword;
    List<string> Purina = new List<string> { "food", "bowl", "puppy", "toys", "chow" };
    string passLvlOne = "marleau";
    string passLvlTwo = "gumbo";
    string passLvlThree = "rosie";
    string password = "null";
    //Enums
    enum Screen { MainMenu, Password, Win};
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello Hacker_01");
    }

    // Update is called once per frame
   
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
        }
    }

    void EnterLevel(int level)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen option: " + level);
        currentScreen = Screen.Password;
        Terminal.WriteLine("Please enter the password: ");

        
       
    }
    void Level(int level, string input)
    {
        if (input == "menu" || input == "Menu")
        {
            ShowMainMenu("Hello Hacker_01 Glad You're Having Fun");
        }
        if (currentScreen == Screen.Password)
        {
            
            if (level == 1)
            {
                password = passLvlOne;
            }
            else if (level == 2)
            {
                password = passLvlTwo;
            }
            else if (level == 3)
            {
                password = passLvlThree;
            }
            else
            {
                ShowMainMenu("Issues Occured Please Try Again");
            }

            if(input == password)
            {
                Winner();
            }
            else
            {
                Terminal.WriteLine("Wrong Password Please Try Again.");
            }
        }
       

    }
    void Winner()
    {
        currentScreen = Screen.Win;
        Terminal.WriteLine("Condragulations, You're a winner baby");


    }

    //void UserPassword(string input)
    //{
    //    userPassword = input;
    //}
    

   
}
