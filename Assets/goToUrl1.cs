using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToUrl1 : MonoBehaviour
{

    // Use this for initialization
    public void onClick()
    {
        Application.OpenURL("http://schedule.tsu.ru/auditories_schedule?building_num=10&auditory_num=");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

