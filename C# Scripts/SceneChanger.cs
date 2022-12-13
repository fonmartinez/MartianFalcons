//Namespace that provide access to the Unity game engine
using UnityEngine;
using UnityEngine.SceneManagement;
//Namespace that provides access to various classes
using System.Collections;
using System.Collections.Generic;

//MonoBehaviour class attached to a Button
//This class define a single method to change scene
public class SceneChanger : MonoBehaviour
{
    //This method is call when we press the Start Button
    public void ChangeScene()
    {
        //Then, the class uses the Engine to load the new scene called "scene2"
        //Thee new scene is loaded, and the current scene is going to be unloaded.
        SceneManager.LoadScene("scene2"); 
    }
}