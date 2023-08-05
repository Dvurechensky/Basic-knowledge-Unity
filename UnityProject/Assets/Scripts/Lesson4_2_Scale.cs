using UnityEngine;

/*
 * Отслеживание нажатий от пользователя
 */
public class Lesson4_2_Scale : MonoBehaviour
{
    /// <summary>
    /// Отправляется, когда пользователь нажимает кнопку мыши
    /// в области GUIElement или Collider
    /// </summary>
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);
    }

    /// <summary>
    /// Отправляется, когда пользователь отпускает кнопку мыши.
    /// </summary>
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x * 2f, transform.localScale.y * 2f, transform.localScale.z * 2f);
    }

    /// <summary>
    /// Вызывается, когда пользователь щелкнул Collider и все еще удерживает мышь.
    /// </summary>
    private void OnMouseDrag()
    {
        // переменной записываються координаты мыши по X и Y
        var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 13f);
        // переменной - объекту присваиваеться переменная с координатами мыши
        var objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //объекту записываються координаты
        transform.position = objPosition; 
    }
}
