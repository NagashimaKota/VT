using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRcon : MonoBehaviour {


    public GameObject onObj;
    public GameObject onObj2;
    public Renderer sura_color;
    public Material[] change_color;
    private Transform sura;

    void Start ()
    {
        sura = GameObject.Find("sura3").GetComponent<Transform>();
	}


    void Update ()
    {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);


        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("タッチパッドをクリックした");
            onObj.SetActive(true);
            //sura_color.material = change_color[0];
        }

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            onObj2.SetActive(true);
            /*
            Debug.Log("トリガーを深く引いた");
            if (sura.transform.localScale.x < 1)
            {
                sura.localScale = Vector3.one;
            }
            else
            {
                sura.localScale = new Vector3(0.2f, 0.3f, 0.2f);
            }
            */

        }
    }
}
