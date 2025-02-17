using UnityEngine;

public class Domino : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballPrefabSpawn;

    GameObject domino;
    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision OtherObject)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;

        if (OtherObject.gameObject.tag == "Button")
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            MakeBall();
            Invoke("NoBalls", 10f);
        }
    }

    void MakeBall()
    {
        Instantiate(ballPrefab, ballPrefabSpawn.transform.position, ballPrefab.transform.rotation);
    }

    void NoBalls()
    {
        this.gameObject.GetComponent<Collider>().enabled = false;
        this.gameObject.GetComponent<Rigidbody>().detectCollisions = false;
    }
}
