using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

    ////Loads game secene
    //public void ButtonClicked(int buttonClicked)
    //{
    //    if (buttonClicked == 1)
    //    {
    //        SceneManager.LoadScene(1);
    //    }
    //    else if (buttonClicked == 2)
    //    {
    //        SceneManager.LoadScene(2);
    //    }
    //    else if (buttonClicked == 3)
    //    {
    //        Application.Quit();

    //    }
    //}

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Block_Out");
    }
}
