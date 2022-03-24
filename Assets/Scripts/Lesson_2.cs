using UnityEngine;

/*
 * Переменные и основные функции
 */

public class Lesson_2 : MonoBehaviour
{
    public int k = 0;
    [SerializeField] private int g = 0;
    private AudioSource audio = null;
    private int i = 0;

    private void Awake()
    {
        print("Awake");
    }

    private void Start()
    {
        print("Hi");
    }

    /// <summary>
    /// Для физики
    /// </summary>
    private void FixedUpdate()
    {
        Debug.Log($"FixedUpdate time: {Time.deltaTime}");
    }

    private void Update()
    {
        Debug.Log($"Update time: {Time.deltaTime}");
    }

    private void Show()
    {
        print(i);
    }
}
