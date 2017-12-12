using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EFieldController : MonoBehaviour {

    public GameObject magnitudeSlider;
    public GameObject rotationScrollbar;
    public GameObject container;
    Slider s;
    Scrollbar r;

    // Use this for initialization
    void Start () {
        s = magnitudeSlider.GetComponent<Slider>();
        r = rotationScrollbar.GetComponent<Scrollbar>();
    }
	
	// Update is called once per frame
	void Update () {
        //gameObject.transform.localScale = new Vector3(s.value, gameObject.transform.localScale.y, s.value);
        gameObject.GetComponent<ParticleSystem>().startSpeed = s.value;
        container.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, r.value * 360));
	}

    private void OnTriggerStay(Collider other)
    {
        Vector3 relative = gameObject.transform.TransformDirection(new Vector3(0f, s.value) * 10f * Time.deltaTime)
            * other.GetComponent<ParticleController>().charge;
        other.GetComponent<Rigidbody>().AddForce(relative);
    }
}
