using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwapBack : MonoBehaviour
{
    //index of current image
 
    public GameObject fon3;
    public GameObject fon4;
    public GameObject logo;
    byte IsFirstClick = 1;

    void Start()
    {
        fon4.SetActive(PlayerPrefs.GetInt("fon4", 0) == 1);
        logo.SetActive(PlayerPrefs.GetInt("logo", 0) == 1);
            fon3.SetActive(PlayerPrefs.GetInt("fon3", 0) == 1);
          
           
          
           
       
    }
        
    public void button1_Click()
    {
        switch (IsFirstClick)
        {
            case 0: // нажали один раз
                    // ваш код на первое нажатие
                IsFirstClick = 1;
                break;
       
            case 1: // нажали третий раз
                    // ваш код на третье нажатие
                IsFirstClick = 0;
                break;
       
            default:

                break;
        }
        if (IsFirstClick == 0)
        {
            HideAll();
            fon3.SetActive(true);
            logo.SetActive(true);
            PlayerPrefs.SetInt("fon3", 1);
            PlayerPrefs.SetInt("logo", 1);
            PlayerPrefs.SetInt("fon4", 0);
            fon4.SetActive(false);
        }
        if (IsFirstClick == 1)
        {
            HideAll();
            fon4.SetActive(true);
            PlayerPrefs.SetInt("fon4", 1);
            PlayerPrefs.SetInt("fon3", 0);
            fon3.SetActive(false);
        }
       


    }
    public void HideAll()
    {
    
        fon3.SetActive(false);
        fon4.SetActive(false);
        logo.SetActive(false);
    }

}
