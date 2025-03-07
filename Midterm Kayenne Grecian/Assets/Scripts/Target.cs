using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType
{
    Destroyable,
    Movable,
    DestroyableWithSound
}

public class Target : MonoBehaviour
{ 
    public AudioSource targetSound;
    public TargetType targetType;
    private Vector3 startingPosition;
    public float maxMovingTargetRange = 3f;

    void Start()
    {
        startingPosition = transform.position;

        if (targetType == TargetType.Destroyable)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.magenta;
        }
        else if (targetType == TargetType.Movable)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.black;
            //Fix: color red is already used by door/key, so now it black cause emo target
        }
        else if (targetType == TargetType.DestroyableWithSound)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
            //Fix: There's a 'u' in Bullet
        {
            Destroy(other.gameObject);
            //Fix: bullet go bye-bye

            if (targetType == TargetType.Destroyable)
            {
                
                gameObject.SetActive(false);

            }
            else if(targetType == TargetType.Movable)
            {
                float randomY = Random.Range(-maxMovingTargetRange, maxMovingTargetRange);
                float randomZ = Random.Range(-maxMovingTargetRange, maxMovingTargetRange);

                transform.position = startingPosition + new Vector3(0f, randomY, randomZ);
            }
            else if (targetType == TargetType.DestroyableWithSound)
            {
                targetSound.Play();
                Debug.Log("Target Destroy Sound Playing!");
                //Fix (kind of): have to actualy adda sound in for the code to progress to the next line
                gameObject.SetActive(false);
            }
        }
    }
}