using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    Green,
    Blue,
    Red
}

public class Key : MonoBehaviour
{
    public KeyColor keyColor;

    private void Start()
    {
        if(keyColor == KeyColor.Green)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if (keyColor == KeyColor.Blue)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
            //Fix: Hes NoT YELLOW >:(
        }
        else if (keyColor == KeyColor.Red)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (keyColor == KeyColor.Green)
            {
                if (player.hasGreenKey == false)
                {
                    player.hasGreenKey = true;
                    Destroy(gameObject);
                    //Fix: Why would you destroy the player D: They've done neothing wrong
                }
            }
            else if (keyColor == KeyColor.Blue)
            {
                if (player.hasBlueKey == false)
                {
                    player.hasBlueKey = true;
                    Destroy(gameObject);
                }
            }
            else if (keyColor == KeyColor.Red)
            //Fix: hey wait a minute.... this bool should be for the red key... -.-
            {
                if (player.hasRedKey == false)
                    //Fix: well, the bool has to first be false to be set to true... so lets make it false
                {
                    player.hasRedKey = true;
                    Destroy(gameObject);
                }
            }
            
        }
    }
}
