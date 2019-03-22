using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHomeSceneFromCalendarOnClick : MonoBehaviour
{
    public void SetIndexScene(int scenesIndex)
    {
        SceneManager.LoadScene(scenesIndex);
    }
}
