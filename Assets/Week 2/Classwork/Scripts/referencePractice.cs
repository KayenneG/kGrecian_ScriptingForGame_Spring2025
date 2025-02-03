using UnityEngine;

public class referencePractice : MonoBehaviour
{
    public Jotunn jotunnController;
    void Start()
    {
        jotunnController.scaleIncrease = 5f;
        jotunnController.RotateJotun();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
