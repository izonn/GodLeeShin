using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public Canvas screen1_canvas; public Canvas screen2_canvas; public CanvasGroup screen1; public CanvasGroup screen2;

    void Awake()
    {
        if (instance == null) instance = this; else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        screen1.alpha = 1; screen1_canvas.enabled = true;
        screen2.alpha = 0; screen2_canvas.enabled = false;
    }

    public void Screen1_Active()
    {
        screen1.alpha = 1; screen1.interactable = true; screen1_canvas.enabled = true; screen2_canvas.enabled = false;
    }

    public void Screen2_Active()
    {
        screen2.alpha = 1; screen2.interactable = true; screen1_canvas.enabled = false; screen2_canvas.enabled = true;
    }
}