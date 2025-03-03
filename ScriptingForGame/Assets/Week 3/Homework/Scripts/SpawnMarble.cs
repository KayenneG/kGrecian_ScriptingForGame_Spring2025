using UnityEngine;

public class SpawnMarble : MonoBehaviour
{
    public GameObject marblePref;
    public Animation guyMan;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            marblePref.SetActive(true);
            guyMan.enabled = true;
        }
    }
}
