using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenuPanel, OptionsMenuPanel, PauseMenuPanel;
    private bool optionsOpen;


    public void StartGame()
    {
        MainMenuPanel.SetActive(false);
        Debug.Log("Game Started");
    }

    public void ToggleOptions()
    { 
        optionsOpen =! optionsOpen;
        OptionsMenuPanel.SetActive(optionsOpen);
        Debug.Log("Options");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

public static class BooleanExtensions
{
    public static int ToInt(this bool value)
    {
        return value ? 1 : 0;
    }
}
