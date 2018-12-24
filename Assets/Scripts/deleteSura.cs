using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteSura : MonoBehaviour {

    public GameObject sura;
    private bool f = true;

    void Start ()
    {
        
    }
	
	
	void Update ()
    {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);


        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("トリガーを深く引いた");
            if (f)
            {
                sura.SetActive(false);
                f = false;
            }
            else
            {
                sura.SetActive(true);
                f = true;
            }

        }
    }
}
