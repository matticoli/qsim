using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(gameObject.transform.InverseTransformDirection(new Vector3(0f, 0f, 0.2f)));
        } else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(gameObject.transform.InverseTransformDirection(new Vector3(0f, 0f, -0.2f)));
        }
    }
}
