using System.Collections;
using UnityEngine;

/*
 * Переменные и основные функции 
 * в порядке иерархии выполнения сверху вниз
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

    #region Поля
    /// <summary>
    /// Публичные поля
    /// </summary>
    public int PoleK = 0;
    /// <summary>
    /// Закрытые поля
    /// </summary>
    private int PoleI = 0;
    /// <summary>
    /// Поля публичные в рамках скрипта 
    /// как для объектов скрипта так и для редактора Unity
    /// закрытые в рамках обращения из других скриптов
    /// </summary>
    [SerializeField] 
    private int PoleG = 0;
    #endregion

    /// <summary>
    /// Свойства 
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
    /// (Больше работает в Unity)
    /// Сброс вызывается, когда пользователь нажимает 
    /// кнопку «Сброс» в контекстном меню Инспектора 
    /// или при первом добавлении компонента. 
    /// Эта функция вызывается только в режиме редактора. 
    /// Сброс чаще всего используется для получения 
    /// хороших значений по умолчанию в Инспекторе.
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
    /// Всегда вызывается до любых функций Start 
    /// и также после того, как префаб был вызван в сцену 
    /// (если GameObject неактивен на момент старта, 
    /// Awake не будет вызван, 
    /// пока GameObject не будет активирован, 
    /// или функция в каком-нибудь прикреплённом скрипте не вызовет Awake).
    /// </summary>
    private void Awake()
    {
        print($"Awake {this.GetType().Name}");
    }

    /// <summary>
    /// (вызывается только если объект активен): 
    /// Эта функция вызывается сразу после включения объекта. 
    /// Это происходит при создании образца MonoBehaviour, 
    /// например, при загрузке уровня или был вызван 
    /// GameObject с компонентом скрипта.
    /// </summary>
    private void OnEnable()
    {
        print($"OnEnable {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается до обновления первого кадра(first frame) 
    /// только если скрипт включен.
    /// </summary>
    private void Start()
    {
        print($"Start {this.GetType().Name}");
    }

    /// <summary>
    /// Зачастую случается, что FixedUpdate вызывается чаще чем Update. 
    /// FU может быть вызван несколько раз за кадр, если FPS низок 
    /// и функция может быть и вовсе не вызвана между кадрами, если FPS высок. 
    /// Все физические вычисления и обновления происходят сразу после FixedUpdate. 
    /// При применении расчётов передвижения внутри FixedUpdate, 
    /// вам не нужно умножать ваши значения на Time.deltaTime. 
    /// Потому что FixedUpdate вызывается в соответствии с надёжным таймером, 
    /// независящим от частоты кадров.
    /// Другие методы физики:
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
    /// Отправляется, когда мышь входит в элемент.
    /// </summary>
    private void OnMouseOver()
    {
        if(ShowMouseEventString == true)
            Debug.Log($"OnMouseOver {this.GetType().Name}");
    }

    /// <summary>
    /// Отправляется, когда мышь входит в элемент или один из его потомков.
    /// </summary>
    private void OnMouseEnter()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseEnter {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается, когда пользователь щелкнул Collider и все еще удерживает мышь.
    /// </summary>
    private void OnMouseDrag()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseDrag {this.GetType().Name}");
    }

    /// <summary>
    /// Отправляется, когда пользователь нажимает кнопку мыши
    /// в области GUIElement или Collider
    /// </summary>

    private void OnMouseDown()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseDown {this.GetType().Name}");
    }

    /// <summary>
    /// Отправляется, когда пользователь отпускает кнопку мыши.
    /// </summary>
    private void OnMouseUp()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseUp {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается, когда мышь больше не находится над Collider.
    /// </summary>
    private void OnMouseExit()
    {
        if (ShowMouseEventString == true)
            Debug.Log($"OnMouseExit {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается раз за кадр. Это главная функция для обновлений кадров.
    /// </summary>
    private void Update()
    {
        if (ShowUpdateString == true)
            Debug.Log($"Update {this.GetType().Name} time: {Time.deltaTime}");
    }

    /// <summary>
    /// Game Logic - строго после Update и перед LateUpdate
    /// yield return null - Сопрограмма продолжит выполнение, после того, как все Update функции были вызваны в следующем кадре.
    /// yield return new WaitForSeconds() - Продолжает выполнение после заданной временной задержки, и после все Update функций, вызванных в итоговом кадре.
    /// yield WWW - продолжает выполнение после завершения WWW-загрузки.
    /// yield StartCoroutine() - сцепляет сопрограмму, и будет ждать, пока не завершится сопрограмма MyFunc.
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
    /// LateUpdate вызывается раз в кадр, после завершения Update. 
    /// Любые вычисления произведённые в Update будут уже выполнены на момент начала LateUpdate. 
    /// Часто LateUpdate используют для преследующей камеры от третьего лица. 
    /// Если вы перемещаете и поворачиваете персонажа в Update, 
    /// вы можете выполнить все вычисления перемещения и вращения камеры в LateUpdate. 
    /// Это обеспечит то, что персонаж будет двигаться до того, как камера отследит его позицию.
    /// </summary>
    private void LateUpdate()
    {
        if(ShowLateUpdateString == true)
            Debug.Log($"LateUpdate {this.GetType().Name} time: {Time.deltaTime}");
    }

    /// <summary>
    /// Scene rendering - строго после выполнения LateUpdate
    /// Вызывается один раз для каждой камеры, если объект в поле зрения.
    /// </summary>
    private void OnWillRenderObject()
    {
        if(ShowSceneRenderingString == true)
            Debug.Log($"OnWillRenderObject {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается до того, как камера отсечёт сцену. Отсечение определяет, 
    /// какие объекты будут видны в камере. OnPreCull вызывается прямо перед тем, 
    /// как начинается отсечение.
    /// </summary>
    private void OnPreCull()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnPreCull {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается тогда, когда объект становится видимым любой камере.
    /// </summary>
    private void OnBecameVisible()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnBecameVisible {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается тогда, когда объект становится невидимым любой камере.
    /// </summary>
    private void OnBecameInvisible()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnBecameInvisible {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается перед тем, как камера начнёт рендерить сцену.
    /// </summary>
    private void OnPreRender()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnPreRender {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается, после того, как все обычные рендеры сцены завершатся. 
    /// Вы можете использовать класс GL или Graphics.DrawMeshNow, 
    /// чтобы рисовать пользовательскую геометрию в данной точке.
    /// </summary>
    private void OnRenderObject()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnRenderObject {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается после того, как камера завершит рендер сцены.
    /// </summary>
    private void OnPostRender()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnPostRender {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается после завершения рендера сцены, 
    /// для возможности пост-обработки изображения экрана.
    /// </summary>
    /// <param name="source">текущий экран</param>
    /// <param name="destination">куда сохранить</param>
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnRenderImage {this.GetType().Name}");
    }

    /// <summary>
    /// Используется для отрисовки гизмо в окне Scene View в целях визуализации.
    /// Только в Editor Unity
    /// </summary>
    private void OnDrawGizmos()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnDrawGizmos {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается несколько раз за кадр и отвечает за элементы интерфейса (GUI). 
    /// Сначала обрабатываются события макета и раскраски, 
    /// после чего идут события клавиатуры/мышки для каждого события.
    /// </summary>
    private void OnGUI()
    {
        if (ShowSceneRenderingString == true)
            Debug.Log($"OnGUI {this.GetType().Name}");
    }

    /// <summary>
    /// (Работает один раз)
    /// Вызывается также после yield WaitForEndFrame
    /// Отправляется всем GameObjects, когда приложение приостанавливается.
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        Debug.Log($"OnApplicationPause {pause} {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается, когда объект отключается или становится неактивным.
    /// </summary>
    private void OnDisable()
    {
        Debug.Log($"OnDisable {this.GetType().Name}");
    }

    /// <summary>
    /// Вызывается для всех игровых объектов перед тем, 
    /// как приложение закрывается. В редакторе вызывается тогда, 
    /// когда игрок останавливает игровой режим. 
    /// В веб-плеере вызывается по закрытия веб окна.
    /// </summary>
    private void OnApplicationQuit()
    {
        Debug.Log($"OnApplicationQuit {this.GetType().Name}");
    }

    /// <summary>
    /// Эта функция вызывается после всех обновлений кадра 
    /// в последнем кадре объекта, пока он ещё существует 
    /// (объект может быть уничтожен при помощи Object.Destroy или при закрытии сцены).
    /// </summary>
    private void OnDestroy()
    {
        Debug.Log($"OnDestroy {this.GetType().Name}");
    }
}
