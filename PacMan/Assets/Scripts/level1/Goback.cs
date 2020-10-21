using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goback : MonoBehaviour
{
    // Start is called before the first frame update
    

    
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {

            //Debug.Log("jefffff");


        }
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
        //DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
