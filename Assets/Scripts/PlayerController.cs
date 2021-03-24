using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private float speed;
    private float directionX;
    private Vector3 localScale;
    //public AudioSource jumpSound;



    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.y < 0.0001)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200f);
            //jumpSound.Play();
        }
        if (Mathf.Abs(directionX) > 0)
        {
            GetComponent<Animator>().SetBool("isRunning", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("isRunning", false);
        }

        if (GetComponent<Rigidbody2D>().velocity.y > 1f)
        {
            GetComponent<Animator>().SetBool("isJumping", true);
            GetComponent<Animator>().SetBool("isFalling", false);
        }
        else if (GetComponent<Rigidbody2D>().velocity.y < -1f)
        {
            GetComponent<Animator>().SetBool("isJumping", false);
            GetComponent<Animator>().SetBool("isFalling", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("isJumping", false);
            GetComponent<Animator>().SetBool("isFalling", false);
        }
    }

    private void FixedUpdate()   //called in fixed frame rate
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(directionX, GetComponent<Rigidbody2D>().velocity.y);
    }

    private void LateUpdate()   //called upon last after both Update and FixedUpdate
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            localScale.x = -0.25f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            localScale.x = 0.25f;
        }

        transform.localScale = localScale;
    }

}
