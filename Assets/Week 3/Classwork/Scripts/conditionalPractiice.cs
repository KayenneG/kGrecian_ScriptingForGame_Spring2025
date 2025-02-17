using UnityEngine;

public class conditionalPractiice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color go2ElseColor;
    void Start()
    {
      //ColorGameObjectByName();
        ChangeColorByTag();
    }

    void Update()
    {
        
    }

    void ColorGameObjectByName()
    {
        Debug.Log("go is named" + go.name);
        Debug.Log("go2 is named" + go2.name);

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>(); //this is done only once, and can be called later in the script to save recources

        if(go.name == "Cube")
        {
            goMeshRenderer.material.color = Color.magenta;

            //go.GetComponent<MeshRenderer>().material.color = Color.magenta; //this is an expensive piece of code, so we add it instead as a local call (see "goMeshRenderer")
            //^^names a specific component type and gets reference to it through code
            //you have to make sure that the component you are trying to get actualy exists, otherwise you will get a null referece exception errror --> code no work
        }
        else if(go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
        }
        else if (go.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 1);
            //changes the color to an RGB value defined here
        }

        MeshRenderer go2MeshRenderer = go.GetComponent<MeshRenderer>();

        if (go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.grey;
        }
        else if (go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.white;
        }
        else if (go2.name == "Cylinder")
        {
            go2MeshRenderer.material.color = Color.red;
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;
            //changed the color to a public color we can change in the inspector
        }
    }

    void ChangeColorByTag()
    {
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "Boi")
        {
            goMeshRenderer.material.color = Color.magenta;
        }
        else if (go.name == "Boin't")
        {
            goMeshRenderer.material.color = Color.cyan;
        }
        else if (go.name == "midBoi")
        {
            goMeshRenderer.material.color = Color.black;
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 1);
        }
    }
}
