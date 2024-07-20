using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour
    
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInParent<CharacterMovement>().score++;
            GameObject.FindGameObjectWithTag("audio").GetComponent<AudioSource>().Play();
            Destroy(this.transform.parent.gameObject);
            Debug.Log(other.GetComponentInParent<CharacterMovement>().score);
        }
    }

}
