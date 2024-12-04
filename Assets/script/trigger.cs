using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class trigger : MonoBehaviour
{

    public PlayableDirector Timeline;

    private void OnTriggerEnter(Collider other)
    {
        Timeline.Play();
    }
}

