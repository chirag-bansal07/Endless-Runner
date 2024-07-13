using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CharacterMovement : MonoBehaviour
{

    public GameObject[] lane;
    int index = 1;
    public float speed=5f;
    private Animator animator;
 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
     
            animator.SetTrigger("Jump");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            animator.SetTrigger("Crouch");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && index<2)
        {
            index++;

        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && index > 0)
        {
            index--;
        }

       
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, lane[index].transform.position, step);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Obstacle")
        {
         
            animator.SetTrigger("Death");
        }
    }
}
