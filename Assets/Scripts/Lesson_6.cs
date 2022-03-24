using System.Collections;
using UnityEngine;

/*
 * Корутины (Coroutines)
 */

public class Lesson_6 : MonoBehaviour
{
    public GameObject instObj;
    private void Start()
    {
         Invoke("Inst", 2f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(instObjects());
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            StopCoroutine(instObjects());
        }
    }

    private void Inst()
    {
        Instantiate(instObj, new Vector3(-10, 10, 10), Quaternion.identity).GetComponent<Renderer>().material.color = Color.green;
    }

    private IEnumerator instObjects()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(instObj, new Vector3(10,10,10), Quaternion.identity).GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(1f);
        Instantiate(instObj, new Vector3(-10, 10, 10), Quaternion.identity).GetComponent<Renderer>().material.color = Color.green;
        int k = 0;
        while (k < 100)
        {
            k++;
            Instantiate(instObj, 
                new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50)), 
                Quaternion.identity).
                            GetComponent<Renderer>().material.color = 
                            new Color(Random.Range(0, 1f), 
                                        Random.Range(0, 1f), 
                                        Random.Range(0, 1f),
                                        Random.Range(0, 1f));
            yield return new WaitForSeconds(0.3f);
        }
    }
}
