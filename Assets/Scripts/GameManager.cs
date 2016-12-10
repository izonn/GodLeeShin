using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public Canvas Status_canvas;
    public Canvas Schedule_canvas;
    public Canvas Store_canvas;
    public Canvas Settings_canvas;
    public CanvasGroup Status;
    public CanvasGroup Schedule;
    public CanvasGroup Store;
    public CanvasGroup Settings;
    public Canvas Active_canvas;

    void Awake()
    {
        if (instance == null) instance = this; else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        Status.alpha = 1; Status_canvas.enabled = true;
        Schedule.alpha = 0; Schedule_canvas.enabled = false;
        Store.alpha = 0; Store_canvas.enabled = false;
        Settings.alpha = 0; Settings_canvas.enabled = false;
        //Active_canvas = Status_canvas;
    }

    public void Status_Active()
    {
        Status.alpha = 1;
        Status.interactable = true;
        Status_canvas.enabled = true;
        if (Active_canvas.name != Status_canvas.name)
        {
            Active_canvas.enabled = false;
            Active_canvas = Status_canvas;
        }
    }

    public void Schedule_Active()
    {
        Schedule.alpha = 1;
        Schedule.interactable = true;

        Schedule_canvas.enabled = true;
        if (Active_canvas.name != Schedule_canvas.name)
        {
            Active_canvas.enabled = false;
            Active_canvas = Schedule_canvas;
        }
    }

    public void Store_Active()
    {
        Store.alpha = 1;
        Store.interactable = true;

        Store_canvas.enabled = true;
        if (Active_canvas.name != Store_canvas.name)
        {
            Active_canvas.enabled = false;
            Active_canvas = Store_canvas;
        }
    }

    public void Settings_Active()
    {
        Settings.alpha = 1;
        Settings.interactable = true;

        Settings_canvas.enabled = true;
        if (Active_canvas.name != Settings_canvas.name)
        {
            Active_canvas.enabled = false;
            Active_canvas = Settings_canvas;
        }
    }

}