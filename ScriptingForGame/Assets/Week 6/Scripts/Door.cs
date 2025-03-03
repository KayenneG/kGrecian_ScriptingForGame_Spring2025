using UnityEngine;

public class Door : MonoBehaviour
{
    public KeyColor doorColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (doorColor == KeyColor.Red)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (doorColor == KeyColor.Blue)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (doorColor == KeyColor.Yellow)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        Destroy(this.gameObject);
    }
}
