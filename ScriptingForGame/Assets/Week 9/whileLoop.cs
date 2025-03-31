using System.Collections;
using UnityEngine;

public class whileLoop : MonoBehaviour
{
    public float speed = 3f;
    Coroutine co;

    void Start()
    {
        /*while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }*/
        co = StartCoroutine(MoveRightAndChangeColor());
    }

    void Update()
    {
        //this code will crash unity, very cool
        // while loops try to complete alltheir code in a single frame, and if the code can't be completed, like below, unity can't go on.
        /*while(this.transform.position.y < 10f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }*/

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
        }
    }

    IEnumerator MoveRightAndChangeColor()
    {
        /*Debug.Log("Frame 1 Runs");
        yield return null;//this will pause the code untillthe next frame
        Debug.Log("Frame 2 Runs");
        yield return new WaitForSeconds(2f);//this will wait 2 seconds before continuing the code
        Debug.Log("Waited 2 seconds");*/


        //this while loop will not allow the code below it to run untill its conditinoal has been comepletely fufilled
        while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.blue;

        yield return new WaitForSeconds(2f);

        while (this.transform.position.x > -8f)
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);
        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
