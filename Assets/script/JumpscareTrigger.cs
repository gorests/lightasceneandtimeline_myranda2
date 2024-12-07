using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    public GameObject jumpscareCanvas; // Assign your canvas in the Inspector
    public AudioClip jumpscareSound;  // Assign a jumpscare sound effect
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Ensure you have an AudioSource component on this object
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure the trigger only activates for the player
        {
            TriggerJumpscare();
        }
    }

    void TriggerJumpscare()
    {
        // Activate the jumpscare canvas
        jumpscareCanvas.SetActive(true);

        // Play the jumpscare sound effect
        if (jumpscareSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(jumpscareSound);
        }

        // Optionally, add a delay to hide the canvas after a few seconds
        Invoke("HideJumpscare", 2f); // Hide after 2 seconds, change as needed
    }

    void HideJumpscare()
    {
        jumpscareCanvas.SetActive(false);
    }
}
