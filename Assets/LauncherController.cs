using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LauncherController : MonoBehaviour {

    public GameObject projectilePrefab;
    public Material proton, electron, neutron;
    public GameObject qSlider;
    Slider q;

    public void Start()
    {
        q = qSlider.GetComponent<Slider>();
    }

    public void Launch()
    {
        GameObject particle = GameObject.Instantiate(projectilePrefab);
        particle.GetComponent<Renderer>().material = (q.value > 0 ? proton : q.value < 0 ? electron : neutron);
        particle.GetComponent<ParticleController>().charge = (int)q.value;
    }
}
