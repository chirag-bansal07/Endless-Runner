using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("collide");
        if (collision.gameObject.tag == "Player")
        {
            
            GameObject.FindGameObjectWithTag("start").GetComponent<CinemachineVirtualCamera>().enabled = false;
            GameObject.FindGameObjectWithTag("Finish").GetComponent<CinemachineVirtualCamera>().enabled = true;
            collision.gameObject.GetComponentInParent<Animator>().SetTrigger("Death");
            collision.gameObject.transform.parent.position = new Vector3(collision.transform.position.x - 1, collision.transform.position.y, collision.transform.position.z - 0.2f);
            Movement[] mov = GameObject.FindObjectsOfType<Movement>();
            collision.gameObject.GetComponentInChildren<CapsuleCollider>().enabled = false;

            foreach (Movement m in mov)
            {
                m.enabled = false;
            }
            collision.gameObject.GetComponentInParent<CharacterMovement>().enabled = false;
            collision.gameObject.GetComponentInParent<AudioSource>().Play();   
            Camera.main.GetComponent<AudioSource>().Pause();
           
            


        }
    }
}
