using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour {

    public GameObject img;
    
	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {

        
        if (Input.GetKey(KeyCode.F))
        {
            if (img != false)
            {
                img.SetActive(true);
            }
            
            
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            img.GetComponent<Renderer>().material.color = Color.blue;
        }

        
	}
}
