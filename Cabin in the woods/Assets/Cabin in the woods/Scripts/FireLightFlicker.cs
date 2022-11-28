using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLightFlicker : MonoBehaviour
{
    [SerializeField]
    private Light light;

    [SerializeField]
    private float lightIntensityMin;

    [SerializeField]
    private float lightIntensityMax;


    // Update is called once per frame
    void Update()
    {
        float lightValue = Random.Range(lightIntensityMin, lightIntensityMax);
        light.intensity = lightValue;
    }
}
