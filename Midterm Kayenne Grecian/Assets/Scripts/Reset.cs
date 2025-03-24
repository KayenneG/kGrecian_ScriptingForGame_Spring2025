using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public List<Target> targets = new List<Target>();//created a new list with the name Targets
    void Start()
    {
        targets = FindObjectsByType<Target>(FindObjectsSortMode.None).ToList();//adds all objects in the scene with the target script component to the targets list
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))//if the R key is pressed;
        {
            foreach (Target t in targets)//every object listed in the targets list
                t.Show();//has has the Show void called and run
        }
    }
}
