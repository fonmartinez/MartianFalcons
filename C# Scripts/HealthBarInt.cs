using UnityEngine;
using VRTK;

// This script is attached to the game object that represents the object
// that the user can grab.
public class HealthBarInt : MonoBehaviour
{
    // The amount by which the health bar will be increased when the object is grabbed.
    public float healthIncreaseAmount = 5.0f;

    // The VRTK_InteractableObject component attached to this game object.
    // It is used to detect when the object is grabbed.
    private VRTK_InteractableObject interactableObject;

    // The HealthSystem component that manages the health bar.
    private HealthCanvas HealthCanvas;

    private void Awake()
    {
        // Get the VRTK_InteractableObject component attached to this game object.
        interactableObject = GetComponent<VRTK_InteractableObject>();

        // Find the HealthSystem component in the scene.
        healthCanvas = GameObject.FindObjectOfType<HealthCanvas>();
    }

    private void OnEnable()
    {
        // Subscribe to the InteractableObjectGrabbed event on the VRTK_InteractableObject component.
        // This event is fired when the object is grabbed by the user.
        interactableObject.InteractableObjectGrabbed += InteractableObjectGrabbed;
    }

    private void OnDisable()
    {
        // Unsubscribe from the InteractableObjectGrabbed event.
        interactableObject.InteractableObjectGrabbed -= InteractableObjectGrabbed;
    }

    // This method is called when the object is grabbed by the user.
    private void InteractableObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        // Increase the health bar by the specified amount.
        healthCanvas.IncreaseHealth(healthIncreaseAmount);
    }
}
