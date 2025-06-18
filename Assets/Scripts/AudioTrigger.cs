using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSrc;
    private void OnTriggerEnter(Collider other) {
        if ((other.CompareTag("Player"))) {
            audioSrc.Play();
        }
    }

    private void OnTriggerExit(Collider other) {
        if ((other.CompareTag("Player"))) {
            audioSrc.Stop();
        }
    }


}
