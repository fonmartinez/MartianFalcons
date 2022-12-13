using UnityEngine;
using VRTK;

// This script is attached to a game object in the scene.
public class Restart : MonoBehaviour
{
    // The name of the scene to load when the health bar is 0.
    public string sceneName = "scene1";

    // The HealthSystem component that manages the health bar.
    private HealthCanvas healthCanvas;

    private void Awake()
    {
        // Find the HealthSystem component in the scene.
        healthCanvas = GameObject.FindObjectOfType<HealthCanvas>();
    }

    private void Update()
    {
        // If the health bar is 0, load the specified scene.
        if (healthCanvas.health <= 0)
        {
            VRTK_SceneHandler.LoadScene("scene1");
        }
    }
}

