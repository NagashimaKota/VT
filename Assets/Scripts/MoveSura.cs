using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSura : MonoBehaviour {

    public Transform sura;
    private float speed = 0.1f;
    

    void Start ()
    {
        
    }


    void Update ()
    {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        var position = device.GetAxis();
        Debug.Log("x: " + position.x + " y: " + position.y);
        sura.Translate(position.x * speed, 0, position.y *speed);
        
    }

}
