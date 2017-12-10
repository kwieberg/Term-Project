using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contributor : MonoBehaviour
{

    public Canvas contributorMenu;
    public Button startText;
    public Button exitText;

    // Use this for initialization
    void Start()
    {

        contributorMenu = contributorMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();//start button
        exitText = exitText.GetComponent<Button>();//exit button
        contributorMenu.enabled = false;//keeps menu from being scene during the game playing process
    }

    public void ExitPress()
    {
        contributorMenu.enabled = true;//whenever you hit the exit button you enable the menu to be displayed
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        contributorMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
