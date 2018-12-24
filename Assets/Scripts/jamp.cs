using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jamp : MonoBehaviour {

    public Transform sura_tr;
    public Rigidbody sura_ri;

    private float lain = 0f;

    void Start ()
    {
		
	}
    
    void Update ()
    {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        

        if (sura_tr.position.y > lain + 0.5f)
        {
            var position = device.GetAxis();
            sura_tr.Translate(position.x / 5, 0, position.y / 5);
            //sura_ri.AddForce(Vector3.forward);

        }
        else
        {
            var position = device.GetAxis();
            sura_tr.Translate(position.x / 10, 0, position.y / 10);
            //sura_ri.AddForce(Vector3.forward * 2);

            if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
            {
                sura_ri.AddForce(0, 200, 0);
            }

        }
        

        if (sura_tr.position.y < 0)
        {
            sura_tr.position = new Vector3(sura_tr.position.x, 0, sura_tr.position.z);
            //sura_ri.AddForce(Vector3.forward);
        }
    }

    public void line(float a)
    {
        lain = a;
        Debug.Log(lain);
    }
}
