using System.Diagnostics.Tracing;
using NUnit.Framework.Internal;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CountTotal : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public int countInt;

    bool timerFinished = false;

    public float timer;
    public TextMeshProUGUI timerText;

    public ListController listScript;

    public TextMeshProUGUI endNumberText;
    public GameObject endNumber;
    public GameObject winText;
    public GameObject looseText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerFinished == false)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                timerFinished = true;
                timer = 0f;
                FinalNumber();
                Debug.Log("Count Change End");
            }
            timerText.text = Mathf.Ceil(timer).ToString("f0");


            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Increase();
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Decrease();
            }
        }
    }

    void Increase()
    {
        countInt++;
        UiUpdate();
    }

    void Decrease()
    {
        if(countInt > 0)
        {
            countInt--;

        }
        UiUpdate();
    }

    void UiUpdate()
    {
        countText.text = countInt.ToString();
    }

    void FinalNumber()
    {
        int finalNumber = listScript.orbSpawnRandom + listScript.bomb.Count;
        Debug.Log("Final Number: " + finalNumber);

        endNumberText.text = "beeboosndfksjdnf" + finalNumber.ToString();
        endNumber.SetActive(true);

        if(countInt == finalNumber)
        {
            Win();
        }
        else
        {
            Loose();
        }
    }

    void Win()
    {
        winText.SetActive(true);
        Debug.Log("YOU WINN");
    }

    void Loose()
    {
        looseText.SetActive(true);
        Debug.Log("YOU LOOSE");
    }
}
