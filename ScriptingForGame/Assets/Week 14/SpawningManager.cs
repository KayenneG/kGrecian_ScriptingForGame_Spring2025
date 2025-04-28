using TMPro;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public bool timerOn = true;
    public TextMeshProUGUI timerText;

    public float clickNumber = 0f;
    public TextMeshProUGUI clickCount;

    public int oneCount;
    public GameObject onePrefab;

    int twoCount;
    int fourCount;
    int fiveCount;
    int sixCount;
    int sevenCount;

    void Start()
    {
        for(int i = 0; i < oneCount; i++)
        {
            int oneYoffset = Random.Range(-20, 36);
            int oneXoffset = Random.Range(-67, 67);

            Vector3 spawnPosition = new Vector3(oneXoffset, oneYoffset, 0);
            GameObject one = Instantiate(onePrefab, spawnPosition, onePrefab.transform.rotation);
        }
    }

    void Update()
    {
        if (timerOn == false)
        {
            Debug.Log("you found the thing)");
        }
        else
        {
            timerCountingUp += Time.deltaTime;
            timerText.text = Mathf.Ceil(timerCountingUp).ToString("Time: " + timerCountingUp);
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickNumber++;
            clickCount.text = Mathf.Ceil(clickNumber).ToString("Click Count: " + clickNumber);

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
                //bad noise
            }
        }

        //if a sprite hits a wall it needs to bounce off in the other direction
    }

    void Win()
    {
        //to text number of clicks
        //to text time taken to win
        //play again button?
        
    }
}
