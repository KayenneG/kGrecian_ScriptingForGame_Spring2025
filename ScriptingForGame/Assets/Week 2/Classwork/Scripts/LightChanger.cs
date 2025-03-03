using UnityEngine;

public class LightChanger : MonoBehaviour
{
    //this calls reference to the specific light COMPONENT we want - the game object component is called light so thats the reference here
    public Light lightMan;

    public Vector3 lightMoveDirection;

    //a bool is basically a checkbox true/false statment
    public bool isItOrIsntIt = false;

    void Start()
    {
        ChangeLightColor(Color.cyan);
       //ChangeLightColor(Color.blue);

        lightMan.color = Color.cyan;
        this.gameObject.SetActive(isItOrIsntIt);
        //lightMan.gameObject.SetActive(false);

        //Destroy(lightMan.gameObject); --> this is how you destroy an object

        //Invoke("AdjustLight", 2f);
    }

    void Update()
    { 
        //AdjustLight(); //the code in this function is called at the start of each frame before moiing onto the rest of the code in update
        Debug.Log("light has been adjusted");

        if(Input.GetKeyDown(KeyCode.B))
        {
            lightMan.color = Color.blue;
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            lightMan.color= Color.green;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            lightMan.color= Color.red;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            lightMan.color= Color.cyan;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            lightMan.gameObject.SetActive(false);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            lightMan.gameObject.SetActive(true);
        }
    }

    private void AdjustLight()
    {
        lightMan.transform.position += lightMoveDirection * Time.deltaTime;
        lightMan.intensity += 40f * Time.deltaTime;
        lightMan.spotAngle += 10f * Time.deltaTime;
        AdjustLight();
    }

    public void ChangeLightColor(Color colorMan) //datatype folowed vy cariable name: color color | color man is a placeholder name for what the color is, so even when cyan or blue, the variable is still called color man (lines 15/16)
    {
        lightMan.color = colorMan;
    }

    //when this object is set active again after being inactive, the code in this function is called
    private void OnEnable()
    {
        
    }

    //when this object is disabled, this code is run beforehand
    private void OnDisable()
    {
        
    }
    
    //this is called before start
    private void Awake()
    {
        
    }

    //called when an object is going to be destroyed, before the object is fully destroyed
    private void OnDestroy()
    {
        
    }
}
