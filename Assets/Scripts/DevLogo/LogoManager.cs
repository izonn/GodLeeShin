using UnityEngine;
using System.Collections;

public class LogoManager : MonoBehaviour {

    public static LogoManager instance = null;
    public Canvas Logo_canvas;
    public CanvasGroup Logo;

    void Awake()
    {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        //Logo.alpha = 0;
        Logo_canvas.enabled = false;
    }

}
