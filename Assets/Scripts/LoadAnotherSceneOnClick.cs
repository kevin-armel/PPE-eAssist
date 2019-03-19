using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAnotherSceneOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        //Application.LoadLevel("Menu 3D");
        //Scene current = ;
        if (SceneManager.Equals(SceneManager.GetActiveScene(), SceneManager.GetSceneAt(0))) //.sceneLoaded)
        {
            SceneManager.UnloadSceneAsync(1);
            SceneManager.UnloadSceneAsync(2);
        }else if (SceneManager.Equals(SceneManager.GetActiveScene(), SceneManager.GetSceneAt(1)))
        {
            SceneManager.UnloadSceneAsync(0);
            SceneManager.UnloadSceneAsync(2);
        }else if(SceneManager.Equals(SceneManager.GetActiveScene(), SceneManager.GetSceneAt(2)))
        {
            SceneManager.UnloadSceneAsync(1);
            SceneManager.UnloadSceneAsync(0);
        }
    }
}
