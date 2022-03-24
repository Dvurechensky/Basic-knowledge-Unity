using UnityEngine;

/*
 * Отслеживание нажатий от пользователя
 */

public class Lesson4_2_Scale : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.localScale = new Vector3 (transform.localScale.x/2, transform.localScale.y/2, transform.localScale.z/2);
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x * 1.3f, transform.localScale.y * 1.3f, transform.localScale.z * 1.3f);
    }
}
