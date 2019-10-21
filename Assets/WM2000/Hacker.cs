using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    enum Screen { Menu, Game, Win };
    Screen currentScreen;
    int level = 0;

    void Start()
    {
        ShowMainMenu();
    }

    // Main game loop
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }

        if (currentScreen == Screen.Menu)
        {
            RunMainMenu(input);
        }

        if (currentScreen == Screen.Game)
        {
            GuessThePassword(input);
        }
    }

    // Screen where user guesses the password
    void GuessThePassword(string input)
    {
        if (input == "donkey")
        {
            Terminal.WriteLine("You guessed right!");
        }
        else
        {
            Terminal.WriteLine("You guessed wrong!");
        }
    }

    // Screen where user chooses the level
    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    // Show message to user when game starts and ask user to guess the password
    void StartGame()
    {
        currentScreen = Screen.Game;
        Terminal.WriteLine("You chose level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }

    // Show main menu messages and ask user to choose the level
    void ShowMainMenu()
    {
        currentScreen = Screen.Menu;
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection: ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
