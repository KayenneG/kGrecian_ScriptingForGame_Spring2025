using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;

    public float speed = 4f;

    public bool hasReachedDestination;
    void Start()
    {
        
    }

    /* void Update()
    {
        
        //this gets the direction every frame, updating when the point 1 moves
        // this casues the point1 to creep toward point 2, slowing down as it approaches becasue the d irection is slowly gettign smaller
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;
        Debug.Log(direction);
        point1.transform.position += direction * Time.deltaTime;
        
    }*/

    /*private void Update()
    {
    //this version normalized the direction of the movement vector, so it travels steadily to ward point 2, multiplied by a speed variable so it can speed up
    //unfortunately, it jitters as it reches the end because it always moves past the exact location of point2, so it goes back and forth untill it tries to reach the exact point. 

        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;

        direction = direction.normalized;
        Debug.Log(direction);

        point1.transform.position += direction * speed * Time.deltaTime;
    }*/

    /* private void Update()
     {
    //in this verson, we check the distance between point1 and point 2, and once its close enough we teleport point1 to point2. not visually noticable that it teleported and the jittering stops
    //however, now point1 is teleporting every single frame. not good
         Vector3 direction;

         direction = point2.transform.position - point1.transform.position;

         direction = direction.normalized;
         //Debug.Log(direction);

         Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));
         if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
         {
             point1.transform.position = point2.transform.position;
         }
         else
         {
             point1.transform.position += direction * speed * Time.deltaTime;
         }
     }*/

    private void Update()
    {
        if (hasReachedDestination == false)
        {
            Vector3 direction;

            direction = point2.transform.position - point1.transform.position;

            direction = direction.normalized;
            //Debug.Log(direction);

            Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));
            if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
            {
                point1.transform.position = point2.transform.position;
                hasReachedDestination = true;
            }
            else
            {
                point1.transform.position += direction * speed * Time.deltaTime;
            }
        }
    }
}
