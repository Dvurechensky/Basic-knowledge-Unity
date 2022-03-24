using UnityEngine;

/*
 * Отслеживание нажатий от пользователя
 */

public class Lesson_4 : MonoBehaviour
{
    public GameObject gameObject;
    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;

    private void Update()
    {
        //float h = Input.GetAxis("Horizontal"); //Edit->ProjectSettings->InputManager (Стрелки влево направо и кнопки A D
        //float xPos = h * range;
        //gameObject.transform.position = new Vector3(xPos, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            gameObject.transform.Translate(Vector3.forward
                                           * moveSpeed
                                           * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            gameObject.transform.Translate(-Vector3.forward
                                           * moveSpeed
                                           * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            gameObject.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            gameObject.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
