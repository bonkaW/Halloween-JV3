using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private ParticleSystem particle;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "InteractableObject") {
            audioSource.Play();
            particle.Play();
            Destroy(other.gameObject);
        }
    }
}
