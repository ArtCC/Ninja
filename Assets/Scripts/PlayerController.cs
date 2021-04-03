using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {    

    public float velocity = 5;
    private Rigidbody2D rigid;
    private float horizontal;

    // Start is called before the first frame update
    void Start() {   
        rigid = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    public void upMovement() {
        Debug.Log("Up");
    }

    public void downMovement() {
        Debug.Log("Down");
    }

    public void leftMovement() {
        Debug.Log("Left");
    }

    public void rightMovement() {
        Debug.Log("Right");
    }

    public void onButtonAction() {
        Debug.Log("onButtonAction");
    }

    public void offButtonAction() {
        Debug.Log("offButtonAction");
    }

    // Private functions
    private void FixedUpdate() {
        rigid.velocity = new Vector2(horizontal * velocity, rigid.velocity.y);
    }
}