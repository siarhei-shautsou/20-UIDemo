using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private string currentScene;
    //private bool scene1Loaded;

    [SerializeField] GameObject uiManager;
    [SerializeField] GameObject sfxManager;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(uiManager);
        DontDestroyOnLoad(sfxManager);
        currentScene = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        //if (scene1Loaded)
        //{
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (uiManager.activeInHierarchy)
            {
                uiManager.SetActive(false);
            }                
            else
            {
                uiManager.SetActive(true);
            }
        }
        //}        
    }

    public void LoadScene(string sceneName)
    {
        //if (!scene1Loaded)
        //{
        AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        if (sceneLoading == null) // preventing errors when scene doesn't exist
        {
            Debug.LogError("Unable to load " + sceneName);
            return;
        }

        sceneLoading.completed += OnLoadingComplete;
        //}
    }

    void OnLoadingComplete(AsyncOperation sceneLoading)
    {
        currentScene = "Scene1";
        uiManager = GameObject.Find("UI Manager");
        uiManager.SetActive(false);
        //scene1loaded = true;
    }

    public void QuitApp()
    {
        Debug.Log("Application.Quit()");
        Application.Quit();
    }
}
