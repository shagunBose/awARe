using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LoadScene : MonoBehaviour {
    //is called before the first frame update
    
    public void changeMenuScene(string sceneName){
    	 SceneManager.LoadScene(sceneName);
    	 Console.WriteLine("Hello World!");
    }
}
