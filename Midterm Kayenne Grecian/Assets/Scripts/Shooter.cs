using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;//creates a game object reference that can be acessed in the inspector called bbulletPrefab
    public float bulletForce;//created a public float acessable in the inspector named bulletForce
    //Fix: you silly goose, you need semicolons at the end of your statement for this to work :)
    public Transform bulletSpawnPosition;//creates a transform vbariable with the name bulletSpawnTransfrom

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//if the 0 key is pressed;
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);//the bullet prefab is instantiated at the defined spawn position

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce);//gets the rigidbody copmonent on the instantiated bullet and sends it flying
            //Fix: now, why would we want the bullet transform to go UP?? forward is the way to go

            Destroy(bullet, 3f);//destroys the instantiated bullet after 3 seconds
            //Fix:  if we want the bullet to be destroyed after 3 seconds, then the value shouldn't be .25f. Lets fix that.
        }
    }
}
