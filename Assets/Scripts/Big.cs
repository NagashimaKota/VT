using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big : MonoBehaviour {

    private Vector3 size = new Vector3(0.01f, 0.01f, 0f);
    private Vector3 mai = new Vector3(0.01f, 0.01f, 0f);

    private float time;

    void Start ()
    {
        
	}


    void Update ()
    {
        if (size.x <= 0.05f)
        {
            //this.gameObject.SetActive(false);
        }
        if (size.x <= 1f)
        {
            size += mai;
            this.GetComponent<Transform>().localScale = size;
        }
        
    }
}
