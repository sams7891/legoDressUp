using UnityEngine;

public class PersistBetweenScenes : MonoBehaviour
{

    public static PersistBetweenScenes instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
