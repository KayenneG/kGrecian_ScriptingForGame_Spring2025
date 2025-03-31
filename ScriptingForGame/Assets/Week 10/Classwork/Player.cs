using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {

    }
}
