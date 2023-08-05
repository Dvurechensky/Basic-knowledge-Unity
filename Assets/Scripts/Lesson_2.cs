using System.Collections;
using UnityEngine;

/*
 * ���������� � �������� ������� 
 * � ������� �������� ���������� ������ ����
 */
public class Lesson_2 : MonoBehaviour
{
    #region Control State
    public bool ShowSceneRenderingString = false;
    public bool ShowMouseEventString = false;
    public bool ShowUpdateString = false;
    public bool ShowFixedUpdateString = false;
    public bool ShowLateUpdateString = false;
    #endregion

    #region ����
    /// <summary>
    /// ��������� ����
    /// </summary>
    public int PoleK = 0;
    /// <summary>
    /// �������� ����
    /// </summary>
    private int PoleI = 0;
    /// <summary>
    /// ���� ��������� � ������ ������� 
    /// ��� ��� �������� ������� ��� � ��� ��������� Unity
    /// �������� � ������ ��������� �� ������ ��������
    /// </summary>
    [SerializeField] 
    private int PoleG = 0;
    #endregion

    /// <summary>
    /// �������� 
    /// </summary>
    public bool StatusReset
    {
        get
        {
            print($"Reset {StatusReset}");
            return true;
        }
    }

    /// <summary>
    /// (������ �������� � Unity)
    /// ����� ����������, ����� ������������ �������� 
    /// ������ ������ � ����������� ���� ���������� 
    /// ��� ��� ������ ���������� ����������. 
    /// ��� ������� ���������� ������ � ������ ���������. 
    /// ����� ���� ����� ������������ ��� ��������� 
    /// ������� �������� �� ��������� � ����������.
    /// </summary>
    [ContextMenu("Reset")]
    private void Reset()
    {
        ShowSceneRenderingString = false;
        ShowMouseEventString = false;
        ShowFixedUpdateString = false;
        ShowUpdateString = false;
        ShowLateUpdateString = false;
        print($"Reset {this.GetType().Name}");
    }

    /// <summary>
    /// ������ ���������� �� ����� ������� Start 
    /// � ����� ����� ����, ��� ������ ��� ������ � ����� 
    /// (���� GameObject ��������� �� ������ ������, 
    /// Awake �� ����� ������, 
    /// ���� GameObject �� ����� �����������, 
    /// ��� ������� � �����-������ ������������ ������� �� ������� Awake).
    /// </summary>
    private void Awake()
    {
        print($"Awake {this.GetType().Name}");
    }

    /// <summary>
    /// (���������� ������ ���� ������ �������): 
    /// ��� ������� ���������� ����� ����� ��������� �������. 
    /// ��� ���������� ��� �������� ������� MonoBehaviour, 
    /// ��������, ��� �������� ������ ��� ��� ������ 
    /// GameObject � ����������� �������.
    /// </summary>
    private void OnEnable()
    {
        print($"OnEnable {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� �� ���������� ������� �����(first frame) 
    /// ������ ���� ������ �������.
    /// </summary>
    private void Start()
    {
        print($"Start {this.GetType().Name}");
    }

    /// <summary>
    /// �������� ���������, ��� FixedUpdate ���������� ���� ��� Update. 
    /// FU ����� ���� ������ ��������� ��� �� ����, ���� FPS ����� 
    /// � ������� ����� ���� � ����� �� ������� ����� �������, ���� FPS �����. 
    /// ��� ���������� ���������� � ���������� ���������� ����� ����� FixedUpdate. 
    /// ��� ���������� �������� ������������ ������ FixedUpdate, 
    /// ��� �� ����� �������� ���� �������� �� Time.deltaTime. 
    /// ������ ��� FixedUpdate ���������� � ������������ � ������� ��������, 
    /// ����������� �� ������� ������.
    /// ������ ������ ������:
    /// yield WaitForFixedUpdate
    /// OnTriggerXXX
    /// OnCollisionXXX
    /// </summary>
    private void FixedUpdate()
    {
        if(ShowFixedUpdateString == true)
            Debug.Log($"FixedUpdate {this.GetType().Name} time: {PoleK++}");
    }

    /// <summary>
    /// ������������, ����� ���� ������ � �������.
    /// </summary>
    private void OnMouseOver()
    {
        if(ShowMouseEventString == true)
            Debug.Log($"OnMouseOver {this.GetType().Name}");
    }

    /// <summary>
    /// ������������, ����� ���� ������ � ������� ��� ���� �� ��� ��������.
    /// </summary>
    private void OnMouseEnter()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseEnter {this.GetType().Name}");
    }

    /// <summary>
    /// ����������, ����� ������������ ������� Collider � ��� ��� ���������� ����.
    /// </summary>
    private void OnMouseDrag()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseDrag {this.GetType().Name}");
    }

    /// <summary>
    /// ������������, ����� ������������ �������� ������ ����
    /// � ������� GUIElement ��� Collider
    /// </summary>

    private void OnMouseDown()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseDown {this.GetType().Name}");
    }

    /// <summary>
    /// ������������, ����� ������������ ��������� ������ ����.
    /// </summary>
    private void OnMouseUp()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseUp {this.GetType().Name}");
    }

    /// <summary>
    /// ����������, ����� ���� ������ �� ��������� ��� Collider.
    /// </summary>
    private void OnMouseExit()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseExit {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� ��� �� ����. ��� ������� ������� ��� ���������� ������.
    /// </summary>
    private void Update()
    {
        if (ShowUpdateString == true)
            Debug.Log($"Update {this.GetType().Name} time: {Time.deltaTime}");
    }

    /// <summary>
    /// Game Logic - ������ ����� Update � ����� LateUpdate
    /// yield return null - ����������� ��������� ����������, ����� ����, ��� ��� Update ������� ���� ������� � ��������� �����.
    /// yield return new WaitForSeconds() - ���������� ���������� ����� �������� ��������� ��������, � ����� ��� Update �������, ��������� � �������� �����.
    /// yield WWW - ���������� ���������� ����� ���������� WWW-��������.
    /// yield StartCoroutine() - �������� �����������, � ����� �����, ���� �� ���������� ����������� MyFunc.
    /// </summary>
    /// <returns></returns>
    private IEnumerator ShowGameLogic()
    {
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(ShowGameLogic());
        print(PoleI);
        yield return null;
    }

    /// <summary>
    /// LateUpdate ���������� ��� � ����, ����� ���������� Update. 
    /// ����� ���������� ������������ � Update ����� ��� ��������� �� ������ ������ LateUpdate. 
    /// ����� LateUpdate ���������� ��� ������������ ������ �� �������� ����. 
    /// ���� �� ����������� � ������������� ��������� � Update, 
    /// �� ������ ��������� ��� ���������� ����������� � �������� ������ � LateUpdate. 
    /// ��� ��������� ��, ��� �������� ����� ��������� �� ����, ��� ������ �������� ��� �������.
    /// </summary>
    private void LateUpdate()
    {
        if(ShowLateUpdateString == true)
            Debug.Log($"LateUpdate {this.GetType().Name} time: {Time.deltaTime}");
    }

    /// <summary>
    /// Scene rendering - ������ ����� ���������� LateUpdate
    /// ���������� ���� ��� ��� ������ ������, ���� ������ � ���� ������.
    /// </summary>
    private void OnWillRenderObject()
    {
        if(ShowSceneRenderingString == true)
            Debug.Log($"OnWillRenderObject {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� �� ����, ��� ������ ������� �����. ��������� ����������, 
    /// ����� ������� ����� ����� � ������. OnPreCull ���������� ����� ����� ���, 
    /// ��� ���������� ���������.
    /// </summary>
    private void OnPreCull()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnPreCull {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� �����, ����� ������ ���������� ������� ����� ������.
    /// </summary>
    private void OnBecameVisible()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnBecameVisible {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� �����, ����� ������ ���������� ��������� ����� ������.
    /// </summary>
    private void OnBecameInvisible()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnBecameInvisible {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� ����� ���, ��� ������ ����� ��������� �����.
    /// </summary>
    private void OnPreRender()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnPreRender {this.GetType().Name}");
    }

    /// <summary>
    /// ����������, ����� ����, ��� ��� ������� ������� ����� ����������. 
    /// �� ������ ������������ ����� GL ��� Graphics.DrawMeshNow, 
    /// ����� �������� ���������������� ��������� � ������ �����.
    /// </summary>
    private void OnRenderObject()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnRenderObject {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� ����� ����, ��� ������ �������� ������ �����.
    /// </summary>
    private void OnPostRender()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnPostRender {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� ����� ���������� ������� �����, 
    /// ��� ����������� ����-��������� ����������� ������.
    /// </summary>
    /// <param name="source">������� �����</param>
    /// <param name="destination">���� ���������</param>
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnRenderImage {this.GetType().Name}");
    }

    /// <summary>
    /// ������������ ��� ��������� ����� � ���� Scene View � ����� ������������.
    /// ������ � Editor Unity
    /// </summary>
    private void OnDrawGizmos()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnDrawGizmos {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� ��������� ��� �� ���� � �������� �� �������� ���������� (GUI). 
    /// ������� �������������� ������� ������ � ���������, 
    /// ����� ���� ���� ������� ����������/����� ��� ������� �������.
    /// </summary>
    private void OnGUI()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnGUI {this.GetType().Name}");
    }

    /// <summary>
    /// (�������� ���� ���)
    /// ���������� ����� ����� yield WaitForEndFrame
    /// ������������ ���� GameObjects, ����� ���������� ������������������.
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        Debug.Log($"OnApplicationPause {pause} {this.GetType().Name}");
    }

    /// <summary>
    /// ����������, ����� ������ ����������� ��� ���������� ����������.
    /// </summary>
    private void OnDisable()
    {
        Debug.Log($"OnDisable {this.GetType().Name}");
    }

    /// <summary>
    /// ���������� ��� ���� ������� �������� ����� ���, 
    /// ��� ���������� �����������. � ��������� ���������� �����, 
    /// ����� ����� ������������� ������� �����. 
    /// � ���-������ ���������� �� �������� ��� ����.
    /// </summary>
    private void OnApplicationQuit()
    {
        Debug.Log($"OnApplicationQuit {this.GetType().Name}");
    }

    /// <summary>
    /// ��� ������� ���������� ����� ���� ���������� ����� 
    /// � ��������� ����� �������, ���� �� ��� ���������� 
    /// (������ ����� ���� ��������� ��� ������ Object.Destroy ��� ��� �������� �����).
    /// </summary>
    private void OnDestroy()
    {
        Debug.Log($"OnDestroy {this.GetType().Name}");
    }
}
