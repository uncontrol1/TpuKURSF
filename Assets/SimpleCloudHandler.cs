using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;




public class SimpleCloudHandler : MonoBehaviour, ICloudRecoEventHandler
{
    public ImageTargetBehaviour ImageTargetTemplate;
    private CloudRecoBehaviour mCloudRecoBehaviour;
    private bool mIsScanning = false;
    private string mTargetMetadata = "";
    
    
    void Start()
    {
        // register this event handler at the cloud reco behaviour
        CloudRecoBehaviour cloudRecoBehaviour = GetComponent<CloudRecoBehaviour>();

        if (cloudRecoBehaviour)
        {
            cloudRecoBehaviour.RegisterEventHandler(this);
        }
        mCloudRecoBehaviour = cloudRecoBehaviour;
        GameObject MainImage = GameObject.Find("tableCAB");
       

    }
   
    public void OnStateChanged(bool scanning)
    {
        mIsScanning = scanning;
        if (scanning)
        {
            // очистить все track
            ObjectTracker tracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
            tracker.TargetFinder.ClearTrackables(false);
        }
    }
    public void OnInitError(TargetFinder.InitState initError)
    {
        Debug.Log("Cloud Reco init error " + initError.ToString());
    }

    public void OnInitialized(TargetFinder targetFinder)
    {
        Debug.Log("Cloud Reco initialized");
    }
    public string IMG;
    public void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult)
    {
        TargetFinder.CloudRecoSearchResult cloudRecoSearchResult =
     (TargetFinder.CloudRecoSearchResult)targetSearchResult;
        mTargetMetadata = cloudRecoSearchResult.MetaData;
       

        GameObject newImageTarget = Instantiate(ImageTargetTemplate.gameObject) as GameObject;
        GameObject MainImage = newImageTarget.transform.GetChild(0).gameObject;
  
        GameObject augmentation = null;
        if (augmentation != null)
            augmentation.transform.SetParent(newImageTarget.transform);
        if(ImageTargetTemplate)
        {
            ObjectTracker tracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
            ImageTargetBehaviour imageTargetBehaviour = (ImageTargetBehaviour)tracker.TargetFinder.EnableTracking(targetSearchResult , newImageTarget);
        }
        
       string IMG = cloudRecoSearchResult.MetaData;

      

        if (!mIsScanning)
        {
            mCloudRecoBehaviour.CloudRecoEnabled = true;
        }
    }

  

    public void OnUpdateError(TargetFinder.UpdateState updateError)
    {
        Debug.Log("Cloud Reco update error " + updateError.ToString());
    }

    // Use this for initialization
    
    void OnGUI()
    {
        // показать статус
        GUI.Box(new Rect(100, 100, 200, 50), mIsScanning ? "Scanning" : "Not scanning");
        // отображение методанных 
        GUI.Box(new Rect(100, 200, 200, 50), "Metadata: " + mTargetMetadata);
        
        if (!mIsScanning)
        {
            if (GUI.Button(new Rect(100, 300, 200, 50), "Restart Scanning"))
            {
                // Restart TargetFinder
                mCloudRecoBehaviour.CloudRecoEnabled = true;
            }
        }

    }
   
}
