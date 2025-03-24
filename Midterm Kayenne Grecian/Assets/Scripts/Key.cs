using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor//this creates a enumerator list compoised of the names specified below
{
    Green,
    Blue,
    Red
}

public class Key : MonoBehaviour
{
    public KeyColor keyColor;//creates a publically acessable variable of the enumerator that we created/listed above ,acessable in the inspector

    private void Start()
    {
        if(keyColor == KeyColor.Green)//if the game object has the enumerator option green, then the action after the if statment will be  run
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object green.
        }
        else if (keyColor == KeyColor.Blue)//if the game object has the enumerator option blue, then the action after the if statment will be  run
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object blue.
            //Fix: Hes NoT YELLOW >:(
        }
        else if (keyColor == KeyColor.Red)//if the game object has the enumerator option red, then the action after the if statment will be  run
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object red.
        }
    }

    void OnTriggerEnter(Collider other)//any time the game object the script is attached to enters the collider of another object, code is run
    {
        if (other.tag == "Player")//if the other object that is collided with has the tag "Player", then the code will run
        {
            Player player = other.GetComponent<Player>();//gets the Player script component from the attached game object so it can reference variables in that script

            if (keyColor == KeyColor.Green)//if the key color is green, the following logic will play
            {
                if (player.hasGreenKey == false)//if the hasGreenKey bool is false on the player script that is being referenced, then the logic will run
                {
                    player.hasGreenKey = true;//sets the hasGeenKey bool to true
                    Destroy(gameObject);//destroys this game object
                    //Fix: Why would you destroy the player D: They've done neothing wrong
                }
            }
            else if (keyColor == KeyColor.Blue)//if the key color is blue, the following logic will play
            {
                if (player.hasBlueKey == false)//if the hasBlueKey bool is false on the player script that is being referenced, then the logic will run
                {
                    player.hasBlueKey = true;//sets the hasBlueKey bool to true
                    Destroy(gameObject);//destroys this game object
                }
            }
            else if (keyColor == KeyColor.Red)//if the key color is red, the following logic will play
            //Fix: hey wait a minute.... this bool should be for the red key... -.-
            {
                if (player.hasRedKey == false)//if the hasRedKey bool is false on the player script that is being referenced, then the logic will run
                                              //Fix: well, the bool has to first be false to be set to true... so lets make it false
                {
                    player.hasRedKey = true;//sets the hasRedKey bool to true
                    Destroy(gameObject);//destroys this game object
                }
            }
            
        }
    }
}
