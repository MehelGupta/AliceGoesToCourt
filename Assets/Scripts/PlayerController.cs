using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    //player stats
    public float speed;
    public int maxHealth = 5;
    int currentHealth;
    //player animation
    public Animator animator;
    public Rigidbody2D rb;
    private float horizontal;
    private bool isFacingRight = false;
    //Visual
    public SpriteRenderer exclamationMark;
    //quest
    private bool nearQuestItem = false;
    private GameObject questItem;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement
        horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //maybe add time delta time idk
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);


        if (vertical != 0 || horizontal != 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        //control E
        if(Input.GetKey(KeyCode.E) && nearQuestItem)
        {
            questItem.SetActive(false);
        }

        Flip();

    }

    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            exclamationMark.flipX = isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.tag == "questItem")
        {
            nearQuestItem = true;
            questItem = collision.gameObject;
        }
        
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
        if(collision.tag == "questItem")
        {
            nearQuestItem = false;
            questItem = null;
        }
        
        
    }



}
