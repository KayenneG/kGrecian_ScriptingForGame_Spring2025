using UnityEngine;

public class TriggerObjectMover : MonoBehaviour
{
    public GameObject wall;

    public bool hasHitTrigger = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(hasHitTrigger == true)
        {
            wall.transform.position += Vector3.right * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            hasHitTrigger = true;
        }
    }
}
