using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suraim : MonoBehaviour {

    public ParticleSystem hikari;
    public Renderer sura_color;
    public Material[] change_color;

    private int count = 0;

    void Start ()
    {
        
    }


    void Update ()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {

        hikari.Play();
        Destroy(col.gameObject);
        count++;

        sura_color.material = change_color[count / 5];


    }
}
