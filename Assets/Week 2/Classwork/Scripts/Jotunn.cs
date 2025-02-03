using UnityEngine;

public class Jotunn : MonoBehaviour
{
    public GameObject jotunn;
    public float scaleIncrease = .5f;
    public GameObject dead;
    Vector3 rotationAmount; 

    public Transform teleport;

    void Start()
    {
        
    }

    void Update()
    {
        jotunn.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if(jotunn.transform.localScale.x > 7)
        {
            dead.SetActive(true);
        }
    }

    public void Discourage()
    {
        jotunn.transform.localScale = Vector3.one;
        scaleIncrease += .2f;
    }

    public void RotateJotun()
    {
        jotunn.transform.Rotate(new Vector3(0f, 0f, -90f)); //this basically creatsed a new vector 3 in the moment, but it can only be used once --> good for testing, not for coding
        // you could also create a variable of type Vector3 to pass into the rotate function

    }

    public void Teleport()
    {
        jotunn.transform.position = teleport.position;
    }
}
