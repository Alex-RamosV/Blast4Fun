using AlterunaFPS;
using Alteruna;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarLife : MonoBehaviour
{
    // UI image to display health bar
    private Image image;
    // Reference to the current player GameObject
    private GameObject currentPlayer;
    // Reference to the Health component
    private Health currentHealth;

    void Awake()
    {
        // Initialize the Image component
        image = GetComponent<Image>();
    }

    void Update()
    {
        // Find the GameObject with the tag "Player"
        currentPlayer = GameObject.FindGameObjectWithTag("Player");

        if (currentPlayer != null)
        {
            // Ensure the player has a Health component
            currentHealth = currentPlayer.GetComponent<Health>();
            if (currentHealth != null)
            {
                // Print the current health points to the console
                print(currentHealth.HealthPoints);

                // Decrease health points if the Z key is pressed
                if (Input.GetKey(KeyCode.Z))
                {
                    currentHealth.HealthPoints--;
                }

                // Update the health bar fill amount
                image.fillAmount = (float)currentHealth.HealthPoints / 100f;

                Debug.Log("Player found: " + currentPlayer.name);
            }
            else
            {
                Debug.LogError("Health component not found on player!");
            }
        }
        else
        {
            Debug.LogError("Player not found!");
        }
    }
}