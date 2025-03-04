using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;
    public bool hasBlueKey = false;
    public bool hasRedKey = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            //Fix: if we want "E" to be the button pressed to start our action, that one has to be the specified key code - not A
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                if (hit.collider.tag == "Door")
                {
                    LockedDoor door = hit.collider.GetComponent<LockedDoor>();
                    
                    if (door.isDoorLocked == false)
                        //Fix: "If the door ISN'T marked as locked" --> should be "== false" for not locked
                    {
                        Debug.Log("Open Unlocked Door");
                        //I addded a debug for testing purposes, no I won't be removing it.
                        door.OpenDoor();
                        //Fix: Made your comment a reality
                    }
                    else if(door.isDoorLocked == true)
                        //Fix: added door locked true code here
                    {
                        if ((door.keyColorRequired == KeyColor.Green && hasGreenKey) ||
                            (door.keyColorRequired == KeyColor.Blue && hasBlueKey) ||
                            (door.keyColorRequired == KeyColor.Red && hasRedKey))
                            //Fix: BLUE KEY FOR BLUE DOOR. EVIL MAN. Took me a moment to find t_t
                        {
                            door.OpenDoor();
                            //Fix: Made your comment a reality (2)
                        }
                    }
                    
                }
            }
        }
    }
}
