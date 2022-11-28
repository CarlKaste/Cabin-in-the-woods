using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource outdoorRainSound;

    [SerializeField]
    private AudioSource indoorRainSound;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
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
