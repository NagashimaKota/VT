using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choko : MonoBehaviour {

    private Transform sura_tr;
    private Vector3 roll;
    private float speed = 0.05f;
    private float time = 0;

    void Start ()
    {
        sura_tr = this.GetComponent<Transform>();
        roll = new Vector3(Mathf.Cos(Random.Range(-1.0f, 1.0f)), 0, Mathf.Sin(Random.Range(-1.0f, 1.0f)));
        sura_tr.Rotate(0, Mathf.Atan2(roll.z, roll.x) * 180f / 3.14f, 0);
    }


    void Update ()
    {
        sura_tr.Translate(roll * speed);
        if (time > 0.5f)
        {
            roll = new Vector3(Mathf.Cos(Random.Range(-1.0f, 1.0f)), 0, Mathf.Sin(Random.Range(-1.0f, 1.0f)));
            sura_tr.Rotate(0, Mathf.Atan2(roll.z, roll.x) * 180f / 3.14f, 0);
            time = 0;
        }

        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        
    }
}
