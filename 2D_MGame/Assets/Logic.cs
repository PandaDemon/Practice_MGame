using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }

    private void FixedUpdate()
    {
        Debug.Log("FixUpdate time !" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update () {
        Debug.Log("Fix time !" + Time.deltaTime);
	}
}
