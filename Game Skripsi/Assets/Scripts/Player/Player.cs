 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int currentHealth;

    [SerializeField]
    private PlayerStats stats;

    [SerializeField]
    private PlayerComponents components;

    private PlayerUtilities utilities;
    private PlayerActions actions;
    private PlayerHealth health;

    public PlayerComponents Components 
    {
        get
        {
            return components;
        }
    }

    public PlayerStats Stats 
    {
        get
        {
            return stats;
        }
    }

    public PlayerActions Actions
    {
        get
        {
            return actions;
        }
    }

    public PlayerUtilities Utilities 
    {
        get
        {
            return utilities;
        }
    }

    public PlayerHealth Health
    {
        get
        {
            return health;
        }
    }

    private void Start()
    {
        actions = new PlayerActions(this);
        utilities = new PlayerUtilities(this);
        health = new PlayerHealth(this);

        stats.Speed = stats.RunSpeed;

        AnyStateAnimation[] animations = new AnyStateAnimation[]
        {
            new AnyStateAnimation(RIG.BODY, "Body_Idle", "Body_Punch"),
            new AnyStateAnimation(RIG.BODY, "Body_Run", "Body_Punch", "Body_Jump"),
            new AnyStateAnimation(RIG.BODY, "Body_Jump", "Body_Punch"),
            new AnyStateAnimation(RIG.BODY, "Body_Fall", "Body_Punch"),
            new AnyStateAnimation(RIG.BODY, "Body_Punch"),

            new AnyStateAnimation(RIG.LEGS, "Legs_Idle", "Legs_Punch"),
            new AnyStateAnimation(RIG.LEGS, "Legs_Run", "Legs_Jump"),
            new AnyStateAnimation(RIG.LEGS, "Legs_Jump"),
            new AnyStateAnimation(RIG.LEGS, "Legs_Fall"),
            new AnyStateAnimation(RIG.LEGS, "Legs_Punch", "Legs_Run", "Legs_Jump"),
        };

        components.Animator.AddAnimations(animations);

        currentHealth = stats.MaxHealth;
        health.SetMaxHealth(currentHealth);
    }

    private void Update()
    {
        Utilities.HandleInput();
        utilities.HandleAir();
    }

    private void FixedUpdate()
    {
        Actions.Move(transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Hurtbox NPC")
        {
            currentHealth -= 20;
            health.SetHealth(currentHealth);
        }
    }
}
