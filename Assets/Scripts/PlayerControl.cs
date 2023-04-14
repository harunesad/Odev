using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float moveSpeed, jumpSpeed;
    [SerializeField] Animator animator;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        Data.data.playerRb.velocity = new Vector2(h * moveSpeed, rb.velocity.y);
        MoveAndRotate(h);
    }
    #region MoveAndRotate
    void MoveAndRotate(float h)
    {
        bool animState = false;
        if (h == 0)
        {
            animState = false;
        }
        else if(h < 0)
        {
            transform.localScale = new Vector3(-5, 5, 1);
            animState = true;
        }
        else
        {
            transform.localScale = new Vector3(5, 5, 1);
            animState = true;
        }
        animator.SetBool("Run", animState);
    }
    #endregion
}
