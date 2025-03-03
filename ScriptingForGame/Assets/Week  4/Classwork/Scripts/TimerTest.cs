using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;

    bool hasFinishedTimer = false;

    public GameObject cube;

    void Start()
    {
        //when using random.range, if you put f after the numbers in the function it will return a decimal number between those two numbers
        //if y oudo noy put and f after the number, it will return a whole number beetween from thje first to last, not including the last number.
        //^ example: random.range(1,4) will return 1, 2, or 3, but not 4. 
        timerMaxDuration = Random.Range(1, 5);

        Invoke("MoveCubeRight", timerMaxDuration);
    }

    //in this update, once the timer passes its max duration. the bool is changed to true which stops additional logic from beiing run. this is how you make sure theomthing can OPNLOY happen once. 
    /*void Update()
    {
        if(hasFinishedTimer == false)
        {
            timerCountingUp += Time.deltaTime;
            //Debug.Log(timerCountingUp);

            if (timerCountingUp >= timerMaxDuration)
            {
                hasFinishedTimer = true;
                Debug.Log("Reach end of Timer");
            }
        }
       
    }*/

    //in this update, the timer counts up, but once it reaces the max  the cube moves to the right without time.deltatime (moves in one motion).
    //we reset the timer counting up to 0 so that the timer will reach 3 again and move the cube again indefinately
    /*void Update()
    {
        timerCountingUp += Time.deltaTime;
        
        if (timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("Reach end of Timer");
            MoveCubeRight();
            //cube.transform.position += Vector3.right;
            timerCountingUp = 0f;
        }

    }*/

    void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;
        if(cube.transform.position.x <10 )
        {
            Invoke("MoveCubeRight", timerMaxDuration);
        }
    }
}
