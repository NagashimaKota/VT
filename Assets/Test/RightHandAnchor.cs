using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandAnchor : MonoBehaviour {

    public BulletMove bulletGenelate;
    private bool t = false;

    void Start()
    {

    }
    
    void Update()
    {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("トリガーを浅く引いた");
            if (t == false)
            {
                t = true;
            }
            else
            {
                t = false;
            }
        }

        if (t)
        {
            bulletGenelate.Genelat();
        }

    }
}
