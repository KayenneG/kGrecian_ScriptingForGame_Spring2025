using TMPro;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public bool timerOn = true;
    public TextMeshProUGUI timerText;

    public float clickNumber = 0f;
    public TextMeshProUGUI clickCount;

    public GameObject win;
    public TextMeshProUGUI finalCount;
    public TextMeshProUGUI finalTime;

    public AudioSource misclick;
    public AudioSource leaf;

    Vector3 spawnPosition;
    public int oneCount;
    public GameObject onePrefab;

    public int twoCount;
    public GameObject twoPrefab;

    public int threeCount;
    public GameObject threePrefab;

    public int fourCount;
    public GameObject fourPrefab;

    public int fiveCount;
    public GameObject fivePrefab;

    public int sixCount;
    public GameObject sixPrefab;

    public int sevenCount;
    public GameObject sevenPrefab;

    void Start()
    {
        for(int i = 0; i < oneCount; i++)
        {
            Offset();
            GameObject one = Instantiate(onePrefab, spawnPosition, onePrefab.transform.rotation);
        }
        for (int i = 0; i < twoCount; i++)
        {
            Offset();
            GameObject one = Instantiate(twoPrefab, spawnPosition, twoPrefab.transform.rotation);
        }
        for (int i = 0; i < threeCount; i++)
        {
            Offset();
            GameObject one = Instantiate(threePrefab, spawnPosition, threePrefab.transform.rotation);
        }
        for (int i = 0; i < fourCount; i++)
        {
            Offset();
            GameObject one = Instantiate(fourPrefab, spawnPosition, fourPrefab.transform.rotation);
        }
        for (int i = 0; i < fiveCount; i++)
        {
            Offset();
            GameObject one = Instantiate(fivePrefab, spawnPosition, fivePrefab.transform.rotation);
        }
        for (int i = 0; i < sixCount; i++)
        {
            Offset();
            GameObject one = Instantiate(sixPrefab, spawnPosition, sixPrefab.transform.rotation);
        }
        for (int i = 0; i < sevenCount; i++)
        {
            Offset();
            GameObject one = Instantiate(sevenPrefab, spawnPosition, sevenPrefab.transform.rotation);
        }
    }

    void Offset()
    {
        int oneYoffset = Random.Range(-14, 28);
        int oneXoffset = Random.Range(-60, 60);

        spawnPosition = new Vector3(oneXoffset, oneYoffset, 0);
    }

    void Update()
    {
        if (timerOn == true)
        {
            timerCountingUp += Time.deltaTime;
            timerText.text = Mathf.Ceil(timerCountingUp).ToString("Time: " + "0");
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickNumber++;
            clickCount.text = Mathf.Ceil(clickNumber).ToString("Attempts: " + "0");

            RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            if (hit.transform != null)
            {
                if(hit.transform.tag == "Boi")
                {
                    timerOn = false;
                    Win();
                    Debug.Log("You found it");
                }
            }
            else
            {
                Debug.Log("Wrong");
                misclick.Play();
            }
        }
    }

    void Win()
    {
        leaf.Play();
        win.SetActive(true);
        finalCount.text = Mathf.Ceil(clickNumber).ToString("Attempts: " + "0");
        finalTime.text = Mathf.Ceil(timerCountingUp).ToString("Time: " + "0");
    }
}
