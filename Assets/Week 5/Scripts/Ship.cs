using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>();
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.None).ToList();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
            //this fires all cannons using a for each loop
            

            //this fires all cannons using a for loop
            /* for(int i = 0; i < cannons.Count; i++)
            {
                cannons[i].FireCannon();
            }*/
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)) //want to fire all even cannons
        {
            FireEvenCannons();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)) //want to fire all odd cannons
        {
            FireOddCannons();
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            FirePowerCannons();
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            FireWeakCannons();
        }
    }
    void FireAllCannons()
    {
        foreach (Cannon c in cannons)
        {
            c.FireCannon();
        }
    }

    void FireEvenCannons()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            //the mod operation, '%', basically does division and gives you the remainder that could not be devided. if that remainder of %2 is 0,. then the numbr is even
            if (i % 2 == 0)
            {
                cannons[i].FireCannon();
            }

        }
    }

    void FireOddCannons()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            //becasue the % mod is an integer, it will only return whole numbers. therefore, % 2 = 1 is odd cannons
            if (i % 2 == 1)
            {
                cannons[i].FireCannon();
            }
        }
    }

    void FirePowerCannons()
    {
        foreach(Cannon c in cannons)
        {
            if(c.cannonForce >= 1500)
            {
                c.FireCannon();
            }
        }
    }

    void FireWeakCannons()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            if (cannons[i].cannonForce < 1000)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
