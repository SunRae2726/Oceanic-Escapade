using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerSound : MonoBehaviour
{
   
    AudioSource audioSource;

    private void Update()
    {
        if (GetComponent<AudioSource>() == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        if(gameObject.GetComponent<SpriteRenderer>().enabled == false && !audioSource.isPlaying)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (Application.isPlaying)
        {
            audioSource = gameObject.GetComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            audioSource.Play();
   
        }
        //if(!audioSource.isPlaying)
        
      
    }
}
