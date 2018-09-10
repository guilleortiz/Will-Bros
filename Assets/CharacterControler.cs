using UnityEngine;
using System.Collections;
using System;

public class CharacterControler : MonoBehaviour {

    public float jumpForce = 10;
    private Rigidbody2D myRigidBody;
    public LayerMask groundLayer;


    void Awake()
    {
        myRigidBody = GetComponent<Rigidbody2D>();//mira el Game Object y busca el rigidbody2d
        
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        //}
	
	}

    private void Jump()
    {
        if (IsToachingGround()) {

            //2ª ley de newton f=m *a , m=F/a
            myRigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }

    }

     bool IsToachingGround() {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 0.5f,groundLayer)){
            return false;
        }
        else {
            return true;
        }

        
    }
}
