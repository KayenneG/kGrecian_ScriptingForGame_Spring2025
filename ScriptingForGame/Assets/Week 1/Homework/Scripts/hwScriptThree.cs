using UnityEngine;

public class hwScriptThree : MonoBehaviour
{
    public string stringOne;
    public string stringTwo;
    public string stringThree;

    string longString;
    void Start()
    {
        //Oh Look, a sentence magically froms. Neato
        longString = stringOne + stringTwo + stringThree;
        Debug.Log("Script Three String: " + longString);
    }

    void Update()
    {
        
    }
}
