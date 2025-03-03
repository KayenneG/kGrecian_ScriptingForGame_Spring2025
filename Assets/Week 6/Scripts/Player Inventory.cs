using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasRedKey = false;
    public bool hasBlueKey = false;
    public bool hasYellowKey = false;
    public GameObject playerCamera;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //are we looking at the door
            RaycastHit hitObject; //contins the data of what will be hit by the raycaast we're about to make

            if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))
            {
                if(hitObject.collider.gameObject.tag == "Door")
                {
                    Door lookedAtDoor = hitObject.collider.gameObject.GetComponent<Door>();
                    if (lookedAtDoor.doorColor == KeyColor.Red && hasRedKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                        Debug.Log("Open Door");
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Blue && hasBlueKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                        Debug.Log("Open Door");
                    }
                    else if(lookedAtDoor.doorColor == KeyColor.Yellow && hasYellowKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                        Debug.Log("Open Door");
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;
            if (pickedUpKeyColor == KeyColor.Red)
            {
                Debug.Log("Red Key");
                hasRedKey = true;
            }
            else if(pickedUpKeyColor == KeyColor.Blue)
            {
                Debug.Log("Blue Key");
                hasBlueKey = true;
            }
            else if(pickedUpKeyColor == KeyColor.Yellow)
            {
                Debug.Log("Yellow Key");
                hasYellowKey = true;
            }
            Destroy(other.gameObject);
        }
    }
}
