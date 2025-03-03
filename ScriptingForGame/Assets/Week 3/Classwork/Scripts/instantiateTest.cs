using UnityEngine;

public class instantiateTest : MonoBehaviour
{

    public GameObject cannonballPrefab;

    public GameObject cannonballSpawnPosition;
    void Start()
    {
        MakeBall();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B) || Input.GetKey(KeyCode.Space)) //B for B A L L --> also 'GetKey' will infinately update, GetKeyDown will only update the frame the key is pressed
        {
            MakeBall();
        }
    }

    void MakeBall()
    {
        Instantiate(cannonballPrefab, cannonballSpawnPosition.transform.position, cannonballPrefab.transform.rotation);
        // this instantiate makes a copy of a prefeb (the one we have set as "cannonballPrefab') and references another game object's transform and places it at that position and rotation
        

    }
}
