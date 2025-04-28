using DG.Tweening;
using UnityEngine;

public class DOTwenPractice : MonoBehaviour
{

    public Transform jotunn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //jotunn.transform.DOMoveX(jotunn.transform.position.x + 500f, 5f);
        //jotunn.transform.DOMove(jotunn.transform.position + (Vector3.right * 500f), 5f);
        //jotunn.transform.DORotate(jotunn.transform.rotation.eulerAngles + new Vector3(0f, 0f, 180), 5f);
        
        Sequence s = DOTween.Sequence();
        s.Append(jotunn.transform.DOMove(jotunn.transform.position + (Vector3.right * 500f), 5f));
        s.Insert(0f, jotunn.transform.DORotate(jotunn.transform.rotation.eulerAngles + new Vector3(0f, 0f, -180f), 5f));
        s.Append(jotunn.transform.DOMove(jotunn.transform.position, 5f));
        s.Insert(5f, jotunn.transform.DORotate(jotunn.transform.rotation.eulerAngles, 5f));
        s.PlayForward();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DOTween.CompleteAll();

            //will complete this singular one. we have to pass the object that has the tween on it, in this case the .transform componentccc
            DOTween.Complete(jotunn.transform);
        }
    }
}
