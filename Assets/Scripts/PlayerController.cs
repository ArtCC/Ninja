using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {    

    public float velocity = 5;
    private Rigidbody2D rigid;
    private float horizontal;
    private Animator animator;

    // Start is called before the first frame update
    void Start() {   
        rigid = GetComponent<Rigidbody2D>();    
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update() {
        //horizontal = Input.GetAxisRaw("Horizontal");
        
        // Player orientation
        if (horizontal < 0.0f) {
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        } else if (horizontal > 0.0f) {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        animator.SetBool("running", horizontal != 0.0f);
    }

    public void upMovement() {
        //Debug.Log("Up");
    }

    public void downMovement() {
        //Debug.Log("Down");
    }

    public void leftMovement() {
        horizontal = -1.0f;
    }

    public void rightMovement() {
        horizontal = 1.0f;
    }

    public void zeroMovement() {
        horizontal = 0.0f;
    }

    public void onButtonAction() {
        animator.SetBool("atackIdle", true);
    }

    public void offButtonAction() {
        animator.SetBool("atackIdle", false);
    }

    // Private functions
    private void FixedUpdate() {
        rigid.velocity = new Vector2(horizontal * velocity, rigid.velocity.y);
    }
}