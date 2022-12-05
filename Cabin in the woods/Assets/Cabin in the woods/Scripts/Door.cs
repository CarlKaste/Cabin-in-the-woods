using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen;
    private float soundTimerStorage;

    [SerializeField]
    private float soundTimer;

    [SerializeField]
    private AudioSource openDoorSound;

    [SerializeField]
    private AudioClip closeDoorSound;

    [SerializeField]
    private Animator doorAnimator;

    private void Start()
    {
        soundTimerStorage = soundTimer;
    }

    public void OpenDoor()
    {
        if(!isOpen)
        {
            isOpen = true;
            doorAnimator.SetBool("isOpen", true);
            openDoorSound.Play();
        }
        else
        {
            isOpen = false;
            doorAnimator.SetBool("isOpen", false);
            
            if (soundTimer > 0)
            {
                soundTimer -= Time.deltaTime;
            }
            else
            {
                openDoorSound.PlayOneShot(closeDoorSound);
                soundTimer = soundTimerStorage;
            }
        }
    }
}
