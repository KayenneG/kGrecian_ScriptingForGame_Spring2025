using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown = 3f;
    public float timerEnd = 0f;

    bool hasFinishedTimer = false;
    void Start()
    {
        
    }

    void Update()
    {
        timerCountingDown -= Time.deltaTime;

        if (timerCountingDown <= timerEnd)
        {
            Debug.Log("Reach end of Timer");
            timerCountingDown = 3f;
        }
    }
}
