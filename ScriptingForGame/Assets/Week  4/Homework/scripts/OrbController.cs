using UnityEngine;

public class OrbController : MonoBehaviour
{
    float maxDuration;

    void Start()
    {
        maxDuration = Random.Range(1f, 5f);
        AddRandomForce();
    }

    void Update()
    {
        
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

    public void Hide()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color32(0, 0, 0, 0);
        transform.GetChild(0).gameObject.SetActive(false);

        Invoke("Show", 5f);
        //I am intentionally making this over 1f becasue I think its more fun that way
        //(also because I made them semi-transparent instead of toggling the mesh, so you 
        //haveto follow them, kinda. I think its cool).
    }
    void Show()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color32(0, 255, 220, 0);
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
