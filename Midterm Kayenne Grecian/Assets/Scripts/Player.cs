using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;//creates a bool that is set to false by default
    public bool hasBlueKey = false;//creates a bool that is set to false by default
    public bool hasRedKey = false;//creates a bool that is set to false by default

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))//if the e button is pressed, then the logic will run
            //Fix: if we want "E" to be the button pressed to start our action, that one has to be the specified key code - not A
        {
            RaycastHit hit;//if camera looks at the thing, its hit by raycast
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))//if camera sends out a raycast and it hits an object
            {
                if (hit.collider.tag == "Door")//and if the object hit by the raycast has the tag 'door'
                {
                    LockedDoor door = hit.collider.GetComponent<LockedDoor>();//gets the script component from the door
                    
                    if (door.isDoorLocked == false)//if the isDoorLocked component is false then:
                        //Fix: "If the door ISN'T marked as locked" --> should be "== false" for not locked
                    {
                        Debug.Log("Open Unlocked Door");//sends a debug log to the console saying the door is openend
                        //I addded a debug for testing purposes, no I won't be removing it.
                        door.OpenDoor();//calls the OpenDoor void in the locked door script
                        //Fix: Made your comment a reality
                    }
                    else if(door.isDoorLocked == true)//if the isDoorLocked component is true then:
                        //Fix: added door locked true code here
                    {
                        if ((door.keyColorRequired == KeyColor.Green && hasGreenKey) ||
                            (door.keyColorRequired == KeyColor.Blue && hasBlueKey) ||
                            (door.keyColorRequired == KeyColor.Red && hasRedKey))//if the keyColorRequired is green and the player has green key, OR keyColorRequired is blue and the player has blue ke, OR keyColorRequired is red and the player has red key then the next line of logic is run
                                                                                 //Fix: BLUE KEY FOR BLUE DOOR. EVIL MAN. Took me a moment to find t_t
                        {
                            door.OpenDoor();//calls the openDoor void 
                            //Fix: Made your comment a reality (2)
                        }
                    }
                    
                }
            }
        }
    }
}
