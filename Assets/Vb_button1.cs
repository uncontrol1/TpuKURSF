using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb_button1 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBthObj;
    // Use this for initialization
    void Start()
    {
        vbBthObj = GameObject.Find("Vb106");
        vbBthObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("http://schedule.tsu.ru/auditories_schedule/?aud_id=4225&bdg_num=10");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}