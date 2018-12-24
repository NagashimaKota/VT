using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boal_Delete : MonoBehaviour {


    void Start ()
    {
		
	}
	
	

	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Transform>().position = new Vector3(0, 3, 0);
        }
    }
}
