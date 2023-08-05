using System.Collections.Generic;
using UnityEngine;

/*
 * Объекты, компоненты, условные операции и циклы
 */
public class Lesson_3 : MonoBehaviour
{
    private Light Light;
    private readonly int numEnemis = 2;
    public List<GameObject> createObjList;

    private void Awake()
    {
        Light = GetComponent<Light>();
        createObjList = new List<GameObject>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            for (int i = 0; i < numEnemis; i++)
            {
                var tC = Instantiate(ControllerLessons.Instance.Lesson_7.Cilinder, new Vector3(Random.Range(-5f, 7f), Random.Range(1f, 7f)), Quaternion.identity);
                tC.name = createObjList.Count.ToString();
                createObjList.Add(tC);
                Debug.Log(createObjList.Count);
            }
        }

        var obj = ControllerLessons.Instance.Lesson_7.CloneObj;
        if (obj == null && createObjList.Count == 0)
            return;

        //если объект Lesson_7 существует в списке Lesson_3
        var existObjLs7 = createObjList.FindIndex((ob) => ob.name == "Cylinder(Clone)");
        if(existObjLs7 == -1 && obj != null)
            createObjList.Add(obj);

        if(Input.GetKeyUp(KeyCode.Space))
            Light.enabled = !Light.enabled;
        if (Input.GetKeyUp(KeyCode.A))
            SetActiveListObj(ref createObjList);
        if (Input.GetKeyUp(KeyCode.V))
            DestroyObhs(ref createObjList);
        if (Input.GetKeyUp(KeyCode.R))
            SetColorObjs(ref createObjList, Color.red);
        if (Input.GetKeyUp(KeyCode.G))
            SetColorObjs(ref createObjList, Color.green);
        if (Input.GetKeyUp(KeyCode.B))
            SetColorObjs(ref createObjList, Color.blue);
    }

    private void SetActiveListObj(ref List<GameObject> objs)
    {
        foreach (var tC in objs)
            tC.SetActive(!tC.activeSelf);
    }

    private void SetColorObjs(ref List<GameObject> objs, Color color)
    {
        foreach (var tC in objs)
            tC.GetComponent<Renderer>().material.color = color;
    }

    private void DestroyObhs(ref List<GameObject> objsList)
    {
        foreach(var tC in objsList)
            Destroy(tC);
        objsList.Clear();
    }
}
