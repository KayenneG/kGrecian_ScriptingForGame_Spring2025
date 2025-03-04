using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public List<Target> targets = new List<Target>();
    void Start()
    {
        targets = FindObjectsByType<Target>(FindObjectsSortMode.None).ToList();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
            Debug.Log("R");
        {

            for (int i = 0; i < targets.Count; i++)
            {
                targets[i].GetComponent<GameObject>().SetActive(true);
            }

            /*foreach(Target target in targets)
            {
                target.GetComponent<GameObject>().SetActive(true);
               
                Debug.Log("ResetTarget");
            }*/
        }
    }
}
