using UnityEngine;

/*
 * Instantiate(Создание объектов)
 */
public class Lesson_5 : MonoBehaviour
{
    public GameObject[] gameObjects;
    private GameObject inst_Object;

    private void Start()
    {
        for(uint i = 0; i < gameObjects.Length; i++)
        {
            var clone = Instantiate(gameObjects[(int)Random.Range(0, 2f)], 
                        gameObjects[(int)Random.Range(0, 2f)].transform.position, 
                        Quaternion.identity);
            ControllerLessons.Instance.Lesson_3.createObjList.Add(clone);
        }

        //Создание и взаимодействие с созданным
        inst_Object = Instantiate(gameObjects[2], new Vector3(10,10,10), Quaternion.identity);
        inst_Object.name = "my";
        inst_Object.GetComponent<Renderer>().material.color = Color.red;
        ControllerLessons.Instance.Lesson_3.createObjList.Add(inst_Object);
    }
}
