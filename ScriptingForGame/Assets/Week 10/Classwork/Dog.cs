using UnityEngine;

public class Dog : Mammal
{
    //ths script already has acess to the other scripts, so you only need to attach the mest specific script to your game obejct.
    public string dogBreed;
    public bool hasFur;

    public GameObject dogSpawn; //assue this is a dog prefab

    protected override void Start()
    {
        base.Start();
    }

    public void InitializeDog(string breed, bool fur)
    {
        dogBreed = breed;
        hasFur = fur;
    }
    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GiveBirth();
        }
    }

    public void Bark()
    {
        Debug.Log("Bark bark bark");
        Debug.Log("Neighbors no likey");
    }

    public override void GiveBirth()
    {
        GameObject go = Instantiate(dogSpawn);
        go.GetComponent<Dog>().InitializeDog("Chipoo", true);
    }
}
