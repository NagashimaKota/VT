using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

    public jamp sura;

    void Start ()
    {
		
	}


    void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "back")
        {
            sura.line(col.gameObject.transform.position.y);
        }
    }
}
