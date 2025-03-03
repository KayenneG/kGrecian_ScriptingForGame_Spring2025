using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform prefabSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Instantiate(prefabToSpawn, prefabSpawnPosition.position, prefabSpawnPosition.rotation);
        }
    }
}
