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
        if (other.CompareTag("Player"))
        {
            outdoorRainSound.Stop();
            indoorRainSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            outdoorRainSound.Play();
            indoorRainSound.Stop();
        }
    }
}
