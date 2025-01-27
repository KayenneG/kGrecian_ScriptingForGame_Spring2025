using UnityEngine;

public class DatatypePractice : MonoBehaviour
{
    //int and float datatypes are both numbers; int are whole float are decimal
    //char is an independent letter, and string is a full 'sting' or letters (words)

    int santaBanta;

    float total;

    public float dinoMan = 2;

    public float mariririririooooo;

    char beebong = 'B';

    string fullPhrase;
    string uhhhhh = "UHHHHHHH";
    string theresMore = "huzzah";

    public string nameIfYouWill;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaBanta = 68;

        santaBanta = (santaBanta + 7) * 2 / 3 - 27;

        Debug.Log(santaBanta);

        Debug.Log(dinoMan);

        //both of these do the same thing! Just different ways of doing it. 
        dinoMan = dinoMan - 2;
        dinoMan -= -2;

        Debug.Log("DinoVal = " + dinoMan);

        Debug.Log(beebong);

        Debug.Log(uhhhhh);

        Debug.Log(nameIfYouWill);

        total = dinoMan + mariririririooooo;

        Debug.Log("total = " + total);

        fullPhrase = uhhhhh + " " + theresMore;
        Debug.Log(fullPhrase);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
