using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType //this creates a enumerator list compoised of the names specified below
{
    Destroyable,
    Movable,
    DestroyableWithSound
}

public class Target : MonoBehaviour
{ 
    public AudioSource targetSound;//creates a publically acessable variable of an audio source that can be used by this script as well as seen/changed in the inspector
    public TargetType targetType;//creates a publically acessable variable of the enumerator that we created/listed above, again this is acessable in the inspector
    private Vector3 startingPosition;// creates a public vector 3 (a 3-unit coordinate) that is accessable and referenced only in this script
    public float maxMovingTargetRange = 3f;//creates a public float (number) can be seen and changed here in the script and inspector, however we are defining it at the start as the number 3

    void Start()
    {
        startingPosition = transform.position;//we are defining our startingPosition vector3variable (defined above) as the same vector 3 of the object this ecript is attached to

        if (targetType == TargetType.Destroyable)//this is where we get to use outr public numerator list, where we get differemt results depending on what we set the object to in the inspector. In this case if the object is set to destroyable, then we will run the next line of code
        {
            this.GetComponent<MeshRenderer>().material.color = Color.magenta;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object magenta.
        }
        else if (targetType == TargetType.Movable)//if the object is set to movable, then we will run the next line of code. if not, we will move on to the next else if statement
        {
            this.GetComponent<MeshRenderer>().material.color = Color.black;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object black.
            //Fix: color red is already used by door/key, so now it black cause emo target
        }
        else if (targetType == TargetType.DestroyableWithSound)//if the object is set to destroyableWithSound, then we will run the next line of code
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow;// references the game object this script is attached to, and searches for the mesh render component. it then uses that component to turn the game object yellow.
        }
    }

    void OnCollisionEnter(Collision other)//any time the game object the script is attached to enters the collider of another object, code is run
    {
        if (other.gameObject.tag == "Bullet")//if the other object that is collided with has the tag "Bullet", then the code will run
            //Fix: There's a 'u' in Bullet
        {
            

            if (targetType == TargetType.Destroyable)//aftrer it has been confirmed that the target has been hit by a 'Bullet', and if the targetType is Destroyable, then the next action will happen
            {
                this.gameObject.SetActive(false);//this will take the game object the script is attached to and set it false
            }
            else if(targetType == TargetType.Movable)//aftrer it has been confirmed that the target has been hit by a 'Bullet', and if the targetType is Movable, then the next action will happen
            {
                float randomY = Random.Range(-maxMovingTargetRange, maxMovingTargetRange);//creates a new float variable called 'randomY', and sets that number between -maxMovingTargetRange and maxMovingTargetrange (defined earlier)
                float randomZ = Random.Range(-maxMovingTargetRange, maxMovingTargetRange);//creates a new float variable called 'randomX', and sets that number between -maxMovingTargetRange and maxMovingTargetrange (defined earlier)

                transform.position = startingPosition + new Vector3(0f, randomY, randomZ);//takes the starting position defined earlier and changing it by the randomY and randomX floats to get a new transform position for the targett
            }
            else if(targetType == TargetType.DestroyableWithSound)//aftrer it has been confirmed that the target has been hit by a 'Bullet', and if the targetType is DestroyableWithSound, then the next action will happen
            {
                targetSound.Play();//plays the audio source defined a bove
                Debug.Log("Target Destroy Sound Playing!");//sends a debug log to the console after the sound plays confirming it played
                //Fix (kind of): have to actualy add a sound in for the code to progress to the next line
                this.gameObject.SetActive(false);//this will take the game object the script is attached to and set it false
            }

            Destroy(other.gameObject);//the other game object (the Bullet prefab) will be destroyed. 
            //Fix: bullet go bye-bye
        }
    }

    public void Show()//new custom command line that sets the game object to active if the void is called (its called in the Reset script)
    {
        this.gameObject.SetActive(true);//this will take the game object the script is attached to and set it true
    }
}