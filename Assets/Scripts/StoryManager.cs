using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StoryManager : MonoBehaviour {

    public static StoryManager instance = null;

    public Object Next_Scene;

    void Awake()
    {
        if (instance == null) instance = this; else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        //Active_canvas = Status_canvas;
    }

    public void Next_Active()
    {
        SceneManager.LoadScene(Next_Scene.name);
    }
   
}
