using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    [SerializeField]
    private float movementSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        transform.position = transform.position + movement * Time.deltaTime * movementSpeed;

        checkFlip();
    }

    void checkFlip()
    {
        if(animator.GetFloat("Horizontal") < 0 && gameObject.GetComponent<SpriteRenderer>().flipX == false){
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(animator.GetFloat("Horizontal") > 0 && gameObject.GetComponent<SpriteRenderer>().flipX == true){
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
