using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    public InputActionProperty pinch;
    public InputActionProperty grip;
    public Animator hand_animate;

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        float grip_value = grip.action.ReadValue<float>();
        hand_animate.SetFloat("Grip", grip_value);

        float trigger_value = pinch.action.ReadValue<float>();
        hand_animate.SetFloat("Trigger", trigger_value);
    }
}
