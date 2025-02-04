using UnityEngine;
using UnityEngine.UI;

public class referenceThisGuy : MonoBehaviour
{
    public GameObject anthonyButtons;
    public GameObject hatsButtons;
    public GameObject itsAnthony;

    public GameObject topHat;
    public GameObject cowboyHat;
    public GameObject propeller;

    public GameObject stoveUI;

    public Transform anthTransform;
    //have anthony's rotation set here, but edit it in the button controller script

    void Start()
    {
        anthTransform.Rotate(0, 0, 0);
    }

    void Update()
    {
        
    }

    public void ByeHiAnthony()
    {
        anthonyButtons.SetActive(false);
        hatsButtons.SetActive(true);
        itsAnthony.SetActive(true);
    }

    public void TopHatSwap()
    {
        topHat.SetActive(true);
        cowboyHat.SetActive(false);
        propeller.SetActive(false);
    }

    public void CowboyHatSwap()
    {
        topHat.SetActive(false);
        cowboyHat.SetActive(true);
        propeller.SetActive(false);
    }

    public void PropellerSwap()
    {
        topHat.SetActive(false);
        cowboyHat.SetActive(false);
        propeller.SetActive(true);
    }

    public void StoveUI()
    {
        stoveUI.SetActive(true);
    }
}
