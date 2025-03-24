using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyColor keyColorRequired;//this is an enum named keyColorRequired

    public Transform doorFinalPosition;//defines a public transform as doorFinalPosition

    public bool isDoorLocked = true;//defines a public bool (aceccable in the inspector) with the name isDoorLocked, and it is automatically set to true

    public bool hasBeenOpened = false;//defines a public bool (aceccable in the inspector) with the name hasBeenOpened, and it is automatically set to false

    public AudioSource doorOpenAlready;//defines an audiosource (added in the inspector)
    //Fix: A sound for later use :o


    private void Start()
    {
        if (keyColorRequired == KeyColor.Green) //if the game object has the enumerator option green, then the action after the if statment will be run
            //silly Anthony, you need TWO equals signs on this one. Don't worry, I got you o7
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object green.
        }
        else if (keyColorRequired == KeyColor.Blue)//if the game object has the enumerator option blue, then the action after the if statment will be run
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object blue.
        }
        else if (keyColorRequired == KeyColor.Red)//if the game object has the enumerator option red, then the action after the if statment will be run
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object red.
        }
    }

    public void OpenDoor()//new custom command line that is run if the void is called
    {
        if(hasBeenOpened == false)//if the hadBeenOpened bool is set to false, the next braket of command lines is run
        {
            this.transform.position = doorFinalPosition.position;//sets the transform to a new position 
            hasBeenOpened = true;//sets the hasBeenOpened bool to true
            //Fix: Set bool to true after door has been opened
        }
        else if(hasBeenOpened == true)//if the hadBeenOpened bool is set to true, the next braket of command lines is run
        {
            doorOpenAlready.Play();//plays the audiosource
            //Fix: fufilled your request. Sound added. nice
        }
        //fix: added the has been opened true statement, and a silly little sound
    }
}
