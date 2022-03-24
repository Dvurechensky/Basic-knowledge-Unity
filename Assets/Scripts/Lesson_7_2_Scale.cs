using UnityEngine;

/*
 * События OnCollision и OnTrigger
 */

public class Lesson_7_2_Scale : MonoBehaviour
{
    /// <summary>
    /// Вызывается когда объект соприкасается с другим объектом (строго наличие RigitBody)
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        print($"{collision.gameObject.name} Enter");
    }

    private void OnCollisionExit(Collision collision)
    {
        print($"{collision.gameObject.name} Exit");
    }

    private void OnCollisionStay(Collision collision)
    {
        print($"{collision.gameObject.name} Stay");
    }

    /// <summary>
    /// Вызывается когда объект соприкасается с другим объектом (строго наличие Collider)
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        print($"{other.gameObject.name} Collider Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        print($"{other.gameObject.name} Collider Exit");
    }

    private void OnTriggerStay(Collider other)
    {
        print($"{other.gameObject.name} Collider Stay");
    }
}
