using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb_button : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject vbBthObj;
    // Use this for initialization
    void Start()
    {
        vbBthObj = GameObject.Find("Vb5d");
        vbBthObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("http://schedule.tsu.ru/auditories_schedule?aud_id=4224&bdg_num=10");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}


