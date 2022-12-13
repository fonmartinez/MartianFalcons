using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider; // The UI Slider that will represent the health bar

    public float maxHealth = 100f; // The maximum health of the player
    public float currentHealth = 100f; // The current health of the player

    public float healthDecreaseRate = 5f; // The rate at which the health bar will decrease

    void Start()
    {
        // Set the initial value of the health bar to the maximum health
        healthSlider.value = CalculateHealth();
    }

    void Update()
    {
        // Decrease the player's health over time
        currentHealth -= healthDecreaseRate * Time.deltaTime;

        // Update the value of the health bar
        healthSlider.value = CalculateHealth();
    }

    float CalculateHealth()
    {
        // Calculate the current value of the health bar as a percentage of the maximum health
        return currentHealth / maxHealth;
    }
}
