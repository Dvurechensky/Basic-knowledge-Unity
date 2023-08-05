using UnityEngine;

/*
 * ������������ ������� �� ������������
 */
public class Lesson4_2_Scale : MonoBehaviour
{
    /// <summary>
    /// ������������, ����� ������������ �������� ������ ����
    /// � ������� GUIElement ��� Collider
    /// </summary>
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);
    }

    /// <summary>
    /// ������������, ����� ������������ ��������� ������ ����.
    /// </summary>
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x * 2f, transform.localScale.y * 2f, transform.localScale.z * 2f);
    }

    /// <summary>
    /// ����������, ����� ������������ ������� Collider � ��� ��� ���������� ����.
    /// </summary>
    private void OnMouseDrag()
    {
        // ���������� ������������� ���������� ���� �� X � Y
        var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 13f);
        // ���������� - ������� �������������� ���������� � ������������ ����
        var objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //������� ������������� ����������
        transform.position = objPosition; 
    }
}
