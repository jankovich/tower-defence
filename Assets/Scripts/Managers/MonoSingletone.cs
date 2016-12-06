using UnityEngine;

public abstract class MonoSingletone<T> : MonoBehaviour where T : MonoSingletone<T>
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject(typeof(T).ToString(), typeof(T)).GetComponent<T>();
                Instance.Init();
            }

            return instance;
        }
    }

    public virtual void Init() { }

    private void Awake()
    {
        if (instance == null)
            instance = this as T;
    }

}
