using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<cannonball> Balls = new List<cannonball>();

    public GameObject cannonballPrefab;
    void Start()
    {
        Balls = FindObjectsByType<cannonball>(FindObjectsSortMode.None).ToList();
        //finds all objects in the scene that have the cannonball script on them and turn them into a list 

        GameObject go = Instantiate(cannonballPrefab);
        //you can add objects directly to a list by calling the variable name.Add();
        //must be the same type as the list. if you want game objects, specify game objects. if you want scripts, specifyt scripts

        //GameObject.FindGameObjectsWithTag("Cannonball").ToList();
        //find all game objects in the scene with the specified tag. returns it as an array of gameobjects you can convert to a list

        Balls.Add(go.GetComponent<cannonball>());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(cannonball ball in Balls)
            {
                ball.AddRandomForce();
            }
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            int randomBall = Random.Range(0, Balls.Count);
            //.count is used to determine how many are in the list

            Balls[randomBall].AddRandomForce();
            //if you want to specify a listed boject, replace the randomBall with a listed number
        }
    }


}
