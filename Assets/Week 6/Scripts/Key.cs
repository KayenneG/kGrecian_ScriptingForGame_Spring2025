using UnityEngine;

public enum KeyColor
{
    Red,
    Blue,
    Yellow
}
public class Key : MonoBehaviour
{
    public KeyColor color;
    void Start()
    {
        if (color == KeyColor.Red)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if(color == KeyColor.Blue)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if(color == KeyColor.Yellow)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
