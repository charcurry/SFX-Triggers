using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundTrigger : MonoBehaviour
{

    public AudioSource sfx;

    private void OnTriggerEnter(Collider other)
    {
        sfx.Play();
    }
}
