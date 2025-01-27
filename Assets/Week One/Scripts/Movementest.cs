using UnityEngine;

public class Movementest : MonoBehaviour
{
    public Vector3 startingPosition;

    public Vector3 moveDirection;

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("He Appears");

        //transforms the positino of the reference object to 0,0,0 --> (Vector 0)
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {

        //deltatime is the time between frames, eg (30fps = 1/30th of a second & 60fps = 1/60th of a second)
        // at 30fps you have 2 units per frame (60/30 = 2 ) at 60 fps you have 1 unit per frame (60/60 = 2) at 120fps. ypuo have 0.5 units per frame (60/120 = 0.5)
        // deltatime takes the per-frame update to per-second instead

        //moveDirection is currently (0,1,1
        this.transform.position += moveDirection * speed * Time.deltaTime; //multiplying by Time.deltaTime means a "per second" instead of "per frame" Update

        Debug.Log("Hes still here");
    }
}
