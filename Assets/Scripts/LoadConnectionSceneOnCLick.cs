﻿/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadConnectionSceneOnCLick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadConnectionSceneOnCLick : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

   
}