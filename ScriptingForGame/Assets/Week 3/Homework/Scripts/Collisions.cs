using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameObject lift;
    public Vector3 liftDirection;
    bool isLifting = false;

    public GameObject gear;
    public Vector3 gearRotation;
    bool isRotating = false;

    public GameObject lever;

    void Start()
    {
        
    }

    void Update()
    {
        if(isRotating == true)
        {
            gear.transform.Rotate(gearRotation * Time.deltaTime);
        }

        if(isLifting == true)
        {
            lift.transform.position += liftDirection * Time.deltaTime;
            lever.transform.Rotate(-118, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "UpForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
        }

        if (other.gameObject.tag == "UpForce2")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 800f);
        }

        if (other.gameObject.tag == "DownForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 200f);
        }

        if (other.gameObject.tag == "Lift")
        {
            isLifting=true;
        }

        if (other.gameObject.tag == "Ball")
        {
            this.gameObject.GetComponent<Collider>().enabled = false;
            isRotating = true;
        }

        if(other.gameObject.tag == "Destroy")
        {
            Destroy(this.gameObject);
        }
    }

}
