using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ex 1
        // SceneManager.LoadScene("Scene 1 - URP - post process");

        // Ex 2
        // SceneManager.LoadSceneAsync("Scene 1 - URP - post process");

        // Ex 3, h�r tar vi och anv�nder coroutine f�r hantera s.k. async processer 
        // som g�llde just f�r LoadSceneAsync
        StartCoroutine(AsyncLoading("Scene 1 - URP - post process"));

    }

    private IEnumerator AsyncLoading(string sceneName) {
        Debug.Log("Before");

        yield return new WaitForSeconds(5);

        AsyncOperation aOperation = SceneManager.LoadSceneAsync(sceneName);
        aOperation.allowSceneActivation = false;


        while (!aOperation.isDone) {

            Debug.Log("Loading!");

            if (aOperation.progress >= 0.9f) {
                Debug.Log("Loading completed, activating scene");
                aOperation.allowSceneActivation = true;
            }

            yield return null;
        }

        Debug.Log("After");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
