using UnityEngine;
using UnityEngine.UI;

/*
 * —обыти€ OnCollision и OnTrigger 
 * про€вл€ющеес€ на объекте Cube 
 * после соприкосновени€ с Wall 
 * и GameObject.Find
 */
public class Lesson_8 : MonoBehaviour
{
    public GameObject instObj;
    private int count = 0;
    [SerializeField]
    private float speed = 4f;
    private Text text;
    private float ZPos = .0f;

    private void Awake()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        text.text = $"{other.gameObject.name}  {count++}";
    }

    private void Update()
    {
        ZPos = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        instObj.transform.Translate(Vector3.forward * speed * ZPos);
    }
}
