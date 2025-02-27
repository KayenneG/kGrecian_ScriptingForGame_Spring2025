using UnityEngine;
using UnityEngine.Rendering.Universal;

public class cannonball : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddRandomForce()
    {
        Vector3 randomDirection = Vector3.zero;

        randomDirection.x = Random.Range(-1f, 1f);
        randomDirection.y = Random.Range(-1f, 1f);
        randomDirection.z = Random.Range(-1f, 1f);

        float forceMultiplier = Random.Range(1000, 5000);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMultiplier);
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        Debug.Log(otherObject.gameObject.name);

        if(otherObject.gameObject.tag == "floor")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            otherObject.gameObject.GetComponent<floorScript>().SayHello(); //you HAVE to make sure the floor object has the floor script for this to work
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

        if(other.gameObject.tag == "UpForce")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1500f);
        }
        else if(other.gameObject.tag == "DownForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 500f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
