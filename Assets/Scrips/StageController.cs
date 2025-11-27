using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StageController : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void PressPlay()
    {
        SceneManager.LoadScene(1);
    }
}
