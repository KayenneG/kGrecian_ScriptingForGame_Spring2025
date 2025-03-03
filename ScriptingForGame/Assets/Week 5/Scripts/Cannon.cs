using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public Transform cannonballSpawnPosition;
    public float cannonForce = 500f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }*/
    }

    public void FireCannon()
    {
        GameObject go = Instantiate(cannonballPrefab, cannonballSpawnPosition.position, cannonballSpawnPosition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * cannonForce);
    }
}
