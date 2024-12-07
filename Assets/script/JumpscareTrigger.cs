using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    public GameObject jumpscareCanvas; // The canvas with the jumpscare elements (image, sound, etc.)
    public AudioClip jumpscareSound;  // The jumpscare sound
    public GameObject deathScreenCanvas; // The death screen UI Canvas

    private AudioSource audioSource;
    private DeathScreenController deathScreenController;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Ensure AudioSource is attached to this object
        deathScreenController = deathScreenCanvas.GetComponent<DeathScreenController>(); // Get the DeathScreenController component
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player triggered the zone
        {
            TriggerJumpscare();
        }
    }

    void TriggerJumpscare()
    {
        // Show the jumpscare canvas (for image and sound)
        jumpscareCanvas.SetActive(true);

        // Play the jumpscare sound
        if (jumpscareSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(jumpscareSound);
        }

        // Wait a few seconds (adjust delay as needed)
        Invoke("ShowDeathScreen", 2f); // After 2 seconds, show the death screen
    }

    void ShowDeathScreen()
    {
        // Hide the jumpscare canvas
        jumpscareCanvas.SetActive(false);

        // Show the death screen canvas (you could also use a fade effect here)
        deathScreenController.ShowDeathScreen();
    }
}
