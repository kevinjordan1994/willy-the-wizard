using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSenses : CoreComponent
{
    #region Check Transforms
    public Transform GroundCheck { get => groundCheck; private set => groundCheck = value; }
    public Transform WallCheck { get => wallCheck; private set => wallCheck = value; }
    public Transform LedgeCheck { get => ledgeCheck; private set => ledgeCheck = value; }
    public float GroundCheckRadius { get => groundCheckRadius; set => groundCheckRadius = value; }
    public float WallCheckDistance { get => wallCheckDistance; set => wallCheckDistance = value; }
    public float LedgeCheckDistance { get => ledgeCheckDistance; set => ledgeCheckDistance = value; }
    public LayerMask WhatIsGround { get => whatIsGround; set => whatIsGround = value; }

    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private Transform ledgeCheck;

    [SerializeField] private float groundCheckRadius;
    [SerializeField] private float wallCheckDistance;
    [SerializeField] private float ledgeCheckDistance;
    [SerializeField] private LayerMask whatIsGround;
    #endregion

    #region Check Functions
    public bool Ground
    {
       get => Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    public bool CheckWall
    {
        get => Physics2D.Raycast(wallCheck.position, transform.right,
        wallCheckDistance, whatIsGround);
    }

    public bool CheckLedge
    {
        get => Physics2D.Raycast(ledgeCheck.position, Vector2.down,
        ledgeCheckDistance, whatIsGround);
    }
    #endregion
}
