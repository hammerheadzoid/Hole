using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlue : MonoBehaviour {

    public float speed = 7.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }


    }
}
