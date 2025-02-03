using UnityEngine;

public class hwScriptOne : MonoBehaviour
{
    int varOne = 10;
    int varTwo = 20;
    int varThree = 30;

    int total;

    void Start()
    {
        //Int Equation
        total = ((varOne + varTwo + varThree) + varThree) / varTwo;

        Debug.Log("Script One total = " + total);
    }

    void Update()
    {
        
    }
}
