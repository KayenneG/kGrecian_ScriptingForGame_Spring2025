using System.Collections;
using UnityEngine;

public class RangedEnemy : Enemy
{
    public GameObject projectilePrefab;

    public Transform projectileSpawnPosition;

    public float projectileForce = 500f;

    Coroutine co;

    protected override void Attack()
    {
        co = StartCoroutine(Fire());
    }

    protected override void Update()
    {
        //this.transform.LookAt(player.transform.position);

        base.Update();
    }

    IEnumerator Fire()
    {
        GameObject go = Instantiate(projectilePrefab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * projectileForce);

        yield return new WaitForSeconds(2f);

        Destroy(go);

        yield return null;
    }
}
