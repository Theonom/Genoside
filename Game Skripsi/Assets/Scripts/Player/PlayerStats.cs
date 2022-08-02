using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public Vector2 Direction { get; set; }
    
    public float Speed { get; set; }

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float runSpeed;

    [SerializeField]
    private int maxHealth;


    public float RunSpeed 
    {
        get
        {
            return runSpeed;
        }
    }

    public float JumpForce
    {
        get
        {
            return jumpForce;
        }
    }

    public int MaxHealth
    {
        get
        {
            return maxHealth;
        }
    }
}
