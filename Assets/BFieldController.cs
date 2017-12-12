using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BFieldController : MonoBehaviour {

    public GameObject magnitudeSlider;
    public GameObject rotationScrollbar;
    public GameObject vertRotationScrollbar;
    public GameObject container;
    Slider s;
    Scrollbar r, rv;

    // Use this for initialization
    void Start () {
        s = magnitudeSlider.GetComponent<Slider>();
        r = rotationScrollbar.GetComponent<Scrollbar>();
        rv = vertRotationScrollbar.GetComponent<Scrollbar>();
    }
	
	// Update is called once per frame
	void Update () {
        //gameObject.transform.localScale = new Vector3(s.value, gameObject.transform.localScale.y, s.value);
        gameObject.GetComponent<ParticleSystem>().startSpeed = s.value;
        container.transform.rotation = Quaternion.Euler(new Vector3(0f, rv.value * 360, r.value * 360));
	}

    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        Vector3 relative = gameObject.transform.TransformDirection(new Vector3(0f, s.value));
        Vector3 crossProd = Vector3.Cross(relative, rb.velocity) * 10f * Time.deltaTime 
            * other.GetComponent<ParticleController>().charge;
        rb.AddForce(crossProd);
    }
}
