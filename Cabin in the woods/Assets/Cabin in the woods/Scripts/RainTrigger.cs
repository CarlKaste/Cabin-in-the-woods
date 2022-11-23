using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource outdoorRainSound;

    [SerializeField]
    private AudioSource indoorRainSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RainSoundTrigger"))
        {
            outdoorRainSound.Stop();
            indoorRainSound.Play();
        }
        else
        {
            outdoorRainSound.Play();
            indoorRainSound.Stop();
        }
    }
}
