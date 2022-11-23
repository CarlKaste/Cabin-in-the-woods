using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen;

    [SerializeField]
    private AudioSource openDoorSound;

    [SerializeField]
    private AudioClip closeDoorSound;

    public void OpenDoor()
    {
        if(!isOpen)
        {
            Vector3 openDoor = new Vector3(0f, 110f, 0f);
            transform.Rotate(openDoor);
            isOpen = true;
            openDoorSound.Play();
            
        }
        else
        {
            Vector3 closeDoor = new Vector3(0f, 0f, 0f);
            transform.Rotate(closeDoor);
            isOpen = false;
            openDoorSound.PlayOneShot(closeDoorSound);
        }
    }
}
