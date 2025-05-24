using System.Collections;      
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour
{
    // public CanvasGroup logo;
    public Animator circleAnimator;
    public string nextSceneName = "MenuScene";
    void Start()
    {
        StartCoroutine(PlaySplash());
    }

    IEnumerator PlaySplash()
    {
        yield return new WaitForSeconds(2f);  // Wait before circle expands
        circleAnimator.Play("CircleExpand.anim");

        // Optional: fade logo out while circle expands
        float duration = 1.5f;
        float time = 0f;
        while (time < duration)
        {
            // logo.alpha = 1f - (time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        // logo.alpha = 0;
        SceneManager.LoadScene(nextSceneName);

    }
}