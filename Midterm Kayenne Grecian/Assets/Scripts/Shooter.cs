using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce;
    //you silly goose, you need semicolons at the end of your statement for this to work :)
    public Transform bulletSpawnPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce);
            //now, why would we want the bullet transform to go UP?? forward is the way to go

            Destroy(bullet, .25f);
        }
    }
}
