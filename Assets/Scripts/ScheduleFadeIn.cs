using UnityEngine;
using System.Collections;

public class ScheduleFadeIn : MonoBehaviour
{
    public void Fade() { StartCoroutine(DoFade()); }

    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha == 0)
        {
            canvasGroup.alpha += Time.deltaTime * 2; yield return null;
        }
        canvasGroup.interactable = true; yield return null;

        GameManager.instance.Schedule_Active();
    }
}