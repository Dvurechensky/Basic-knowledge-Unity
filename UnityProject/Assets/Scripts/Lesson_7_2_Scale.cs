using UnityEngine;

/*
 * ������� OnCollision � OnTrigger
 */
public class Lesson_7_2_Scale : MonoBehaviour
{
    /// <summary>
    /// ���������� ����� ������ ������������� � ������ 
    /// �������� (������ ������� RigitBody)
    /// </summary>
    /// <param name="collision">Collision</param>
    private void OnCollisionEnter(Collision collision)
    {
        print($"OnCollisionEnter {GetType().Name} {collision.gameObject.name} Enter");
    }

    /// <summary>
    /// OnCollisionExit ����������, ����� ���� ���������/������� 
    /// ���� �������� �������� ������� �������� ����/����������.
    /// </summary>
    /// <param name="collision">Collision</param>
    private void OnCollisionExit(Collision collision)
    {
        print($"OnCollisionExit {GetType().Name} {collision.gameObject.name} Exit");
    }

    /// <summary>
    /// OnCollisionStay �������� ���� ��� � ����� ��� ������� 
    /// ����������/�������� ����, ������� �������� ������� �������� ����/����������.
    /// </summary>
    /// <param name="collision">Collision</param>
    private void OnCollisionStay(Collision collision)
    {
        print($"OnCollisionStay {GetType().Name} {collision.gameObject.name} Stay");
    }

    /// <summary>
    /// ���������� ����� ������ ������������� 
    /// � ������ �������� (������ ������� Collider)
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        print($"OnTriggerEnter {GetType().Name} {other.gameObject.name} Collider Enter");
    }

    /// <summary>
    /// OnTriggerExit ����������, ����� ��������� other �������� �������� ��������.
    /// </summary>
    /// <param name="other">Collider</param>
    private void OnTriggerExit(Collider other)
    {
        print($"OnTriggerExit {GetType().Name} {other.gameObject.name} Collider Exit");
    }

    /// <summary>
    /// OnTriggerStay ���������� ����� �� ���� ������ ��� ������� ������� ����������, ����������� ��������.
    /// </summary>
    /// <param name="other">Collider</param>
    private void OnTriggerStay(Collider other)
    {
        print($"OnTriggerStay {GetType().Name} {other.gameObject.name} Collider Stay");
    }
}
