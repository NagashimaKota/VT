using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenelateFlopiy : MonoBehaviour {

    public GameObject fllpiy;
    public Vector3[] trans;

    private float time = 0;

    void Start () {
		
	}
	
	
	void Update () {

        if (time > 2)
        {
            for (int i=0; i<trans.Length; i++)
            {
                GameObject f = Instantiate(fllpiy);
                f.GetComponent<Transform>().position = trans[i];
                f.GetComponent<Rigidbody>().AddForce(Vector3.up);
            }
            time = 0;
        }

        time += Time.deltaTime;
	}
    
}
