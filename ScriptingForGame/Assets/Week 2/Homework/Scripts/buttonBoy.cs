using Unity.VisualScripting;
using UnityEngine;

public class buttonBoy : MonoBehaviour
{
    public referenceThisGuy buttonController;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            buttonController.anthTransform.Rotate(0, 0, 90);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            buttonController.StoveUI();
        }
    }
    public void Begin()
    {
        buttonController.ByeHiAnthony();
    }

    public void TopHat()
    {
        buttonController.TopHatSwap();
    }

    public void CowboyHat()
    {
        buttonController.CowboyHatSwap();
    }

    public void Propeller()
    {
        buttonController.PropellerSwap();
    }
}