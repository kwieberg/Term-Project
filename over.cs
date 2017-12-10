using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class over : MonoBehaviour
{

    public Canvas overMenu;
    public Button startText;
    public Button exitText;

    // Use this for initialization
    void Start()
    {

        overMenu = overMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();//start button
        exitText = exitText.GetComponent<Button>();//exit button
        overMenu.enabled = false;//keeps menu from being scene during the game playing process
    }

    public void ExitPress()
    {
        overMenu.enabled = true;//whenever you hit the exit button you enable the menu to be displayed
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        overMenu.enabled = false;
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
