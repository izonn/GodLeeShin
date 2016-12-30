using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuManger : MonoBehaviour {

    public static MainMenuManger instance = null;

    public Object Newgame_Scene;
    public Object Continue_Scene;
    public Object Options_Scene;
    public Object Albums_Scene;

    void Awake()
    {
        if (instance == null) instance = this; else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        //Active_canvas = Status_canvas;
    }

    public void Newgame_Active()
    {
        SceneManager.LoadScene(Newgame_Scene.name);
    }

    public void Continue_Active()
    {
        SceneManager.LoadScene(Continue_Scene.name);
    }

    public void Options_Active()
    {
        SceneManager.LoadScene(Options_Scene.name);
    }

    public void Albums_Active()
    {
        SceneManager.LoadScene(Albums_Scene.name);
    }

}
