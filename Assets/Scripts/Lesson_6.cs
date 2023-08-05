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
         Invoke("CreateObj", 2f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            StartCoroutine(InstObjects());
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            StopCoroutine(InstObjects());
        }
    }

    private void CreateObj()
    {
        var clone = Instantiate(instObj, new Vector3(-10, 10, 10), Quaternion.identity);
        clone.GetComponent<Renderer>().material.color = Color.green;
        ControllerLessons.Instance.Lesson_3.createObjList.Add(clone);
    }

    private IEnumerator InstObjects()
    {
        yield return new WaitForSeconds(1.5f);
        var clone_1 = Instantiate(instObj, new Vector3(10, 10, 10), Quaternion.identity);
        clone_1.GetComponent<Renderer>().material.color = Color.red;
        ControllerLessons.Instance.Lesson_3.createObjList.Add(clone_1);
        yield return new WaitForSeconds(1f);
        var clone_2 = Instantiate(instObj, new Vector3(-10, 10, 10), Quaternion.identity);
        clone_2.GetComponent<Renderer>().material.color = Color.green;
        ControllerLessons.Instance.Lesson_3.createObjList.Add(clone_2);
        int k = 0;
        while (k < 2)
        {
            k++;
            var clone_3 = Instantiate(instObj,
                new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)),
                Quaternion.identity);
            clone_3.GetComponent<Renderer>().material.color = 
                        new Color(Random.Range(0, 1f), 
                                    Random.Range(0, 1f), 
                                    Random.Range(0, 1f),
                                    Random.Range(0, 1f));
            ControllerLessons.Instance.Lesson_3.createObjList.Add(clone_3);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
