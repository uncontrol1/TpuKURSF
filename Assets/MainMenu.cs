using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject ButtonsMenu;
    public GameObject ButtonsExit;
    public GameObject ButtinsAuthor;
    public GameObject ButtinsMAP;
    public GameObject ButtinsSheld;
    public GameObject ButtinsSettings;
    public GameObject logo;

    // Update is called once per frame

    public void ShowExitButtons() 
    {
        ButtonsMenu.SetActive(false);
        ButtonsExit.SetActive(true);
        logo.SetActive(false);
    }
    public void BackInMenu()
    {
        ButtonsMenu.SetActive(true);
        logo.SetActive(true);
        ButtonsExit.SetActive(false);
       
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
        
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("menu");
       
    }
    public void ShowAuthor()
    {
        ButtonsMenu.SetActive(false);
        ButtinsAuthor.SetActive(true);
        logo.SetActive(false);
    }
    public void ShowMap()
    {
        ButtinsSheld.SetActive(false);
        ButtinsMAP.SetActive(true);
    }
    public void ShowSheld()
    {
        ButtinsSheld.SetActive(true);
        ButtinsMAP.SetActive(false);
    }
    public void ShowSettings()
    {
        ButtinsSettings.SetActive(true);
        logo.SetActive(true);
        ButtonsMenu.SetActive(false);
        
    }

}
