using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public Vector3 movement;
    public int speed = 1;

    void Start()
    {
        movement.x = Random.Range(-1f, 1f);
        movement.y = Random.Range(-1f, 1f);
    }

    void Update()
    {
        this.transform.position += movement * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit");

        if (other.gameObject.tag == "Verticle")
        {
            movement.x *= -1;
        }
        if (other.gameObject.tag == "Horizontal")
        {
            movement.y *= -1;
        }
    }
}
