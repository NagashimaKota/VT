using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    public GameObject bullet;
    

    void Start () {
		
	}
	
	
	void Update () {
        
    }

    public void Genelat()
    {
        GameObject tama = Instantiate(bullet);
        tama.GetComponent<Transform>().position = this.transform.position;
        tama.GetComponent<Rigidbody>().AddForce(this.transform.forward * 500);
    }
}
