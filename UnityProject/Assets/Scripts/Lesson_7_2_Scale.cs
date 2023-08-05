using UnityEngine;

/*
 * События OnCollision и OnTrigger
 */
public class Lesson_7_2_Scale : MonoBehaviour
{
    /// <summary>
    /// Вызывается когда объект соприкасается с другим 
    /// объектом (строго наличие RigitBody)
    /// </summary>
    /// <param name="collision">Collision</param>
    private void OnCollisionEnter(Collision collision)
    {
        print($"OnCollisionEnter {GetType().Name} {collision.gameObject.name} Enter");
    }

    /// <summary>
    /// OnCollisionExit вызывается, когда этот коллайдер/жесткое 
    /// тело перестал касаться другого твердого тела/коллайдера.
    /// </summary>
    /// <param name="collision">Collision</param>
    private void OnCollisionExit(Collision collision)
    {
        print($"OnCollisionExit {GetType().Name} {collision.gameObject.name} Exit");
    }

    /// <summary>
    /// OnCollisionStay вызывает один раз в кадре для каждого 
    /// коллайдера/жесткого тела, который касается вопроса жесткого тела/коллайдера.
    /// </summary>
    /// <param name="collision">Collision</param>
    private void OnCollisionStay(Collision collision)
    {
        print($"OnCollisionStay {GetType().Name} {collision.gameObject.name} Stay");
    }

    /// <summary>
    /// Вызывается когда объект соприкасается 
    /// с другим объектом (строго наличие Collider)
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        print($"OnTriggerEnter {GetType().Name} {other.gameObject.name} Collider Enter");
    }

    /// <summary>
    /// OnTriggerExit вызывается, когда коллайдер other перестал касаться триггера.
    /// </summary>
    /// <param name="other">Collider</param>
    private void OnTriggerExit(Collider other)
    {
        print($"OnTriggerExit {GetType().Name} {other.gameObject.name} Collider Exit");
    }

    /// <summary>
    /// OnTriggerStay вызывается почти во всех кадрах для каждого другого коллайдера, касающегося триггера.
    /// </summary>
    /// <param name="other">Collider</param>
    private void OnTriggerStay(Collider other)
    {
        print($"OnTriggerStay {GetType().Name} {other.gameObject.name} Collider Stay");
    }
}
