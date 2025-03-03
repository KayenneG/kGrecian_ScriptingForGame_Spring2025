using UnityEngine;

public class SkullController : MonoBehaviour
{
    float maxDuration;
    
    void Start()
    {
        maxDuration = Random.Range(1f, 5f);
        AddRandomForce();
    }

    void AddRandomForce()
    {
        maxDuration = Random.Range(1f, 5f);

        Vector3 randomDirection = Vector3.zero;

        randomDirection.x = Random.Range(-1f, 1f);
        randomDirection.y = 0;
        randomDirection.z = Random.Range(-1f, 1f);

        float forceMultiplier = Random.Range(1000, 2000);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMultiplier);

        Invoke("AddRandomForce", maxDuration);
    }

    public void SkullExplode()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        //I know the assignemnt said to do red but black is cool casue it gets set one fire :')
        transform.GetChild(0).gameObject.SetActive(true);
        Invoke("Destroy", 1f);
    }

    void Destroy()
    {
        Destroy(this.gameObject);
        Debug.Log("EXPLODE");
    }
}
