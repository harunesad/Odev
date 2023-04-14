using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data data;
    public Animator playerAnim, enemyAnim;
    public float playerMoveSpeed, enemyAnimSpeed, playerJumpSpeed;
    public Rigidbody2D playerRb, enemyRb;
    private void Awake()
    {
        data = this;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
