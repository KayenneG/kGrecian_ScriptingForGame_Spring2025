using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListController : MonoBehaviour
{
    public List<OrbController> Invisible = new List<OrbController>();
    public GameObject orb;
    int orbSpawnRandom;
    int orbInvisRandom;

    public List<SkullController> Bomb = new List<SkullController>();
    public GameObject skull;
    int skullSpawnRandom;
    int skullExplodeRandom;
    bool explosionViable = true;
    public GameObject explosionParticles;


    void Start()
    {
        orbSpawnRandom = Random.Range(10, 20);
        orbInvisRandom = Random.Range(3, 7);
        Debug.Log(orbSpawnRandom);

        for (int i = 0; i < orbSpawnRandom; i++)
        {
            SpawnOrb();
        }
         
        Invoke("Invis", orbInvisRandom);


        skullSpawnRandom = Random.Range(10, 20);
        skullExplodeRandom = Random.Range(5, 11);
        Debug.Log(skullSpawnRandom);

        for (int i = 0; i < skullSpawnRandom; i++)
        {
            SpawnSkull();
        }

        Invoke("Explode", skullExplodeRandom);

        Invoke("NoExplode", 26);
    }

    void Update()
    {
        
    }

    private void SpawnOrb()
    {
        Vector3 newPos = new Vector3(Random.Range(-69.3f,72.8f), 50, Random.Range(-100.5f, 94.4f));

        GameObject go = Instantiate(orb, newPos, Quaternion.identity) as GameObject;
        Invisible = FindObjectsByType<OrbController>(FindObjectsSortMode.None).ToList();

    }

    void Invis()
    {
        orbInvisRandom = Random.Range(3, 6);
        
        int randomOrb1 = Random.Range(0, Invisible.Count);
        Invisible[randomOrb1].Hide();

        Invoke("Invis", orbInvisRandom);
        // the same ONE ORB turns invisible every time, doesn't seem all that random to me.
        // need to make it 2 orbs turn invisible, not just one.
    }

    private void SpawnSkull()
    {
        Vector3 newPos = new Vector3(Random.Range(-69.3f, 72.8f), 50, Random.Range(-100.5f, 94.4f));

        GameObject go = Instantiate(skull, newPos, Quaternion.identity) as GameObject;
        Bomb = FindObjectsByType<SkullController>(FindObjectsSortMode.None).ToList();
    }

    void NoExplode()
    {
        explosionViable = false;
        Debug.Log("No More Explosions");
    }
    void Explode()
    {
        if(explosionViable == true)
        {
            skullExplodeRandom = Random.Range(5, 11);

            int randomSkull = Random.Range(0, Bomb.Count);
            Bomb[randomSkull].SkullExplode();
            //I want to add code her that instantiates a perticle system in the location of the skill that will be destroyedd
            Instantiate(explosionParticles);

            Invoke("Explode", skullExplodeRandom);

            GetComponent<AudioSource>().Play();

            Bomb.Remove(Bomb[randomSkull]);
        }
    }

}
