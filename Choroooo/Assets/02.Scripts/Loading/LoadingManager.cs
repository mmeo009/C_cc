using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    public Image bar;
    protected GameManager GameManager => GameManager.Instance;
    void Start()
    {
        StartCoroutine(LoadingProcess());
    }
    IEnumerator LoadingProcess()
    {
        AsyncOperation aO = SceneManager.LoadSceneAsync(GameManager.SceneName);
        aO.allowSceneActivation = false;

        float timer = 0f;
        while (!aO.isDone)
        {
            yield return null;

            if (aO.progress < 0.9f)
            {
                bar.fillAmount = aO.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                bar.fillAmount = Mathf.Lerp(0.9f, 1f, timer);
                if (bar.fillAmount >= 1.0f)
                {
                    aO.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }
}
