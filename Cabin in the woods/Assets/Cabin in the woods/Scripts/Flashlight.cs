using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField]
    private Material lightBulb;

    [SerializeField]
    private Light light;

    [SerializeField]
    private AudioSource clickSound;

    private bool isOn;

    public void UseFlashLight()
    {
        isOn = !isOn;

        if(isOn)
        {
            clickSound.Play();
            lightBulb.EnableKeyword("_emission");
            light.enabled = true;
        }
        else
        {
            clickSound.Play();
            lightBulb.DisableKeyword("_emission");
            light.enabled = false;
        }
    }
}
