using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject JumpscareCam;
    public GameObject FPSCONTROLLER;
    public AudioSource JumpscareAudio;
    public Animator Enemy;
    public bool JumpscareCamOn;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        JumpscareCam.SetActive(false);
        FPSCONTROLLER.SetActive(true);
        JumpscareCamOn = false;
        Enemy = Enemy.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            JumpscareCamOn = true;
            if(JumpscareCamOn == true)
            {
                player.transform.Translate(0, 0, 5);
                JumpscareAudio.Play();
                Enemy.Play("Jumpscare");
            }
        }
    }
}

