using UnityEngine;

/*
 * События OnCollision и OnTrigger
 */

public class Lesson_7 : MonoBehaviour
{
    public GameObject obj;
    private GameObject inst_obj;
    [SerializeField]
    private float speed = 4f;

    private void Start()
    {
        inst_obj = Instantiate(obj, Vector3.zero, Quaternion.identity);
    }

    private void Update()
    {
        float zPoz = Input.GetAxis("Vertical");

        inst_obj.transform.Translate(Vector3.forward * speed * zPoz * Time.deltaTime);
    }
}
