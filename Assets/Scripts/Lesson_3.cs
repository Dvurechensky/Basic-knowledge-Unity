using UnityEngine;

/*
 * Объекты, компоненты, условные операции и циклы
 */

public class Lesson_3 : MonoBehaviour
{
    public GameObject gameObject;
    private Light light;
    private int numEnemis = 10;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
            light.enabled = !light.enabled;
        if(Input.GetKeyUp(KeyCode.A))
            gameObject.SetActive(!gameObject.activeSelf);
        if (Input.GetKeyUp(KeyCode.S))
            Destroy(gameObject);
        if (Input.GetKeyUp(KeyCode.R))
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        if (Input.GetKeyUp(KeyCode.G))
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        if (Input.GetKeyUp(KeyCode.B))
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        if (Input.GetKeyUp(KeyCode.K))
        {
            for (int i = 0; i < numEnemis; i++) Instantiate(new GameObject()).name = $"i={i}";
        }
    }
}
