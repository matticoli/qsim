using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ParticleController : MonoBehaviour {

    public int charge = 0;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, -3f);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
