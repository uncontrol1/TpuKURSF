using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LocalizationManager : MonoBehaviour {
   
    public void language_Rus()
    {
        string language = "Rus";
        PlayerPrefs.SetString("Language", language);
        SceneManager.LoadScene("menu");
        
    }
	
	public void language_Eng()
    {
        string language = "Eng";
        PlayerPrefs.SetString("Language", language);
        SceneManager.LoadScene("menu");
       
    }
    public void NextScene()
    {
        SceneManager.LoadScene("menu");
    }
   
}
