using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudioTrigger : MonoBehaviour
{
    public AudioSource music;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        music.Pause();
    }

    private void OnTriggerExit(Collider other)
    {
        music.Play();
    }
}
