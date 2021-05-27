using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOLO : MonoBehaviour
{
    public Rigidbody2D rb;
    public CapsuleCollider2D body;
    public CircleCollider2D head;
    public Animator anim;
    public float Speed;
    public float JumpSpeed;
    public int JumpTimes;
    // Start is called before the first frame update
    void Start()
    {
        /*Speed = 8f;
        JumpSpeed = 30f;*/
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    public void Move()
    {
        float HorizontalMove = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(HorizontalMove*Speed,rb.velocity.y);

        if (!(rb.velocity.x == 0))
            transform.localScale = new Vector3((rb.velocity.x < 0) ? -1 : 1, 1, 1);
        

    }
    public void Jump() {

        if (PlayerIsTouching(GameObject.FindGameObjectWithTag("Ground").GetComponent<Collider2D>())) {
            Debug.Log("Touch");
            JumpTimes = 1;
        }
        
            
        float VerticalMove = Input.GetAxisRaw("Jump");
        if (JumpTimes > 0 && Input.GetKeyDown(KeyCode.Space))
        {   
            rb.velocity = new Vector2(rb.velocity.x, VerticalMove * JumpSpeed);
            JumpTimes--;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") { 
            
        }
    }

    public bool PlayerIsTouching(Collider2D collider)
    {
        if (
            gameObject.GetComponent<CapsuleCollider2D>().IsTouching(collider) ||
            gameObject.GetComponent<CircleCollider2D>().IsTouching(collider)
            )
            return true;
        else
            return false;


    }
}
