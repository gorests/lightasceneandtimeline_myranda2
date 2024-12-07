using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject Death;           // The death object (representing player death or condition)
    public GameObject DeathScreen;     // The death screen that will show after death

    // Method to restart the game (reloads the scene)
    public void Restart()
    {
        SceneManager.LoadScene(0); // Reload the first scene (main game scene)
    }

    // Method to go to the main menu (loads scene 1)
    public void MainMenu()
    {
        SceneManager.LoadScene(1); // Load the main menu scene
    }

    // This method is called when the player enters the trigger zone
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the object entering the trigger is the player
        {
            // Trigger the death sequence
            Death.SetActive(true); // You can modify this to match your actual death logic
            StartCoroutine(DeathScreenLoader()); // Start showing the death screen after a delay
        }
    }

    // Coroutine to wait for a delay and then show the death screen
    public IEnumerator DeathScreenLoader()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds (adjust if needed)

        DeathScreen.SetActive(true); // Show the death screen

        // Unlock the cursor and make it visible
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Ensure the death screen is inactive when the game starts
    void Start()
    {
        DeathScreen.SetActive(false); // Initially hide the death screen
    }
}
