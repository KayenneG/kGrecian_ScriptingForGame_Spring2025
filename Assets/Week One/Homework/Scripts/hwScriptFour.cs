using UnityEngine;

public class hwScriptFour : MonoBehaviour
{
    Vector3 startingPos;
    public Vector3 moveDirect;

    void Start()
    {
        this.transform.position = startingPos;
    }

    void Update()
    {
        this.transform.position += moveDirect * Time.deltaTime;
    }
}
