using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerComponents
{
    [SerializeField]
    private Rigidbody2D rigidBody;

    [SerializeField]
    private AnyStateAnimator animator;

    [SerializeField]
    private LayerMask groundLayer;

    [SerializeField]
    private Collider2D collider;

    [SerializeField]
    private Slider slider;

    public Rigidbody2D RigidBody 
    {
        get
        {
            return rigidBody;
        }
    }

    public AnyStateAnimator Animator 
    {
        get
        {
            return animator;
        }
    }

    public LayerMask GroundLayer 
    {
        get
        {
            return groundLayer;
        }
    }

    public Collider2D Collider 
    {
        get
        {
            return collider;
        }
    }

    public Slider Slider
    {
        get
        {
            return slider;
        }
    }
}
