using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyColor keyColorRequired;

    public Transform doorFinalPosition;

    public bool isDoorLocked = true;

    public bool hasBeenOpened = false;

    public AudioSource doorOpenAlready;
    //Fix: A sound for later use :o


    private void Start()
    {
        if (keyColorRequired == KeyColor.Green)
            //silly Anthony, you need TWO equals signs on this one. Don't worry, I got you o7
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if (keyColorRequired == KeyColor.Blue)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (keyColorRequired == KeyColor.Red)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    public void OpenDoor()
    {
        if(hasBeenOpened == false)
        {
            this.transform.position = doorFinalPosition.position;
            hasBeenOpened = true;
            //Fix: Set bool to true after door has been opened
        }
        if(hasBeenOpened == true)
        {
            doorOpenAlready.Play();
            //Fix: fufilled your request. Sound added. nice
        }
        //fix: added the has been opened true statement, and a silly little sound
    }
}
