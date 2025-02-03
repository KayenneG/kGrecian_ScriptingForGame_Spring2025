using UnityEngine;

public class hwScriptTwo : MonoBehaviour
{
    public float varOne;
    public float varTwo;
    public float varThree;

    float total;

    void Start()
    {
        //Float Equation
        total = (varOne /  varTwo) * varTwo - varThree;
        Debug.Log("Script Two total = " + total);
    }

    void Update()
    {
        
    }
}
