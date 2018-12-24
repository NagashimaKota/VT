using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour {

    public Text text;
    public Text time_tex;

    private int i = 0;
    private float time = 30;

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (time > 0 && i > 0)
        {
            time -= Time.deltaTime;
        }
        else if(time <= 0)
        {
            time = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            time = 30;
            i = 0;
            text.text = "count:" + i.ToString();
        }
        time_tex.text = "time:" + time.ToString("N0");
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("back") && time > 0)
        {
            i++;
            text.text = "count:" + i.ToString();
        }
    }
}
