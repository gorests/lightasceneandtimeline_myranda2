using UnityEngine;
using UnityEngine.SceneManagement; // For reloading scenes

public class DeathScreenController : MonoBehaviour
{
    public GameObject deathScreenCanvas; // Assign your death screen Canvas in the Inspector

    // This function will be called after the jumpscare finishes
    public void ShowDeathScreen()
    {
        // Show the death screen
        deathScreenCanvas.SetActive(true);

        // Optionally, you can stop time if you want a freeze effect
        Time.timeScale = 0f; // This stops all time in the game. If you want to pause the game, you can use this.
    }

    // This function is for restarting the game (e.g., after a button click)
    public void RestartGame()
    {
        Time.timeScale = 1f; // Make sure time is running again
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    // This function is for quitting the game (e.g., after a button click)
    public void QuitGame()
    {
        Time.timeScale = 1f; // Make sure time is running again
        Application.Quit(); // Quit the application
    }
}
