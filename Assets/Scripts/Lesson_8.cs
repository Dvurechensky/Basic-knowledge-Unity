using UnityEngine;
using UnityEngine.UI;

/*
 * Пользовательский интерфейс и GameObject.Find
 */

public class Lesson_8 : MonoBehaviour
{
    public GameObject instObj;
    private int count;
    [SerializeField]
    private float speed = 4f;
    private Text text;

    private void Start()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        text.text = other.gameObject.name + "  " + count++;
    }

    private void Update()
    {
        float zPoz = Input.GetAxis("Vertical");

        instObj.transform.Translate(Vector3.forward * speed * zPoz * Time.deltaTime);
    }
}
