using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChokoGenelator : MonoBehaviour {

    public GameObject choko;
    public Vector3[] pos;

    private float time = 0;

    void Start ()
    {
		
	}


    void Update ()
    {
        if (time > 1)
        {
            int i = Random.Range(0, pos.Length);
            GameObject pum = Instantiate(choko, pos[i], Quaternion.identity);
            time = 0;
        }
        time += Time.deltaTime;
	}
}
