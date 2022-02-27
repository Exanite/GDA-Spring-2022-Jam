using System.Collections;
using Project.Source;
using UnityEngine;
using UnityEngine.UI;

public class FadeTransition : SingletonBehaviour<FadeTransition>
{
    public Image image;

    public IEnumerator FadeIn(float duration)
    {
        var timer = 0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;

            var alpha = Mathf.Lerp(0, 1, timer / duration);
            var color = image.color;
            color.a = alpha;
            image.color = color;

            yield return null;
        }
    }

    public IEnumerator FadeOut(float duration)
    {
        var timer = 0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;

            var alpha = Mathf.Lerp(1, 0, timer / duration);
            var color = image.color;
            color.a = alpha;
            image.color = color;

            yield return null;
        }
    }
}