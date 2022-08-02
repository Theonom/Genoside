﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions
{
    private Player player;

    public PlayerActions(Player player)
    {
        this.player = player;
    }

    public void Move(Transform transform)
    {
        player.Components.RigidBody.velocity = new Vector2(player.Stats.Direction.x * player.Stats.Speed * Time.deltaTime, player.Components.RigidBody.velocity.y);

        if (player.Stats.Direction.x != 0)
        {
            transform.localScale = new Vector3(player.Stats.Direction.x < 0 ? -1 : 1, 1, 1);
            player.Components.Animator.TryPlayAnimation("Body_Run");
            player.Components.Animator.TryPlayAnimation("Legs_Run");
        }
        else if (player.Components.RigidBody.velocity == Vector2.zero)
        {
            player.Components.Animator.TryPlayAnimation("Body_Idle");
            player.Components.Animator.TryPlayAnimation("Legs_Idle");
        }
    }

    public void Jump()
    {
        if (player.Utilities.IsGrounded())
        {
            player.Components.RigidBody.AddForce(new Vector2(0, player.Stats.JumpForce), ForceMode2D.Impulse);
            player.Components.Animator.TryPlayAnimation("Body_Jump");
            player.Components.Animator.TryPlayAnimation("Legs_Jump");
        }
    }

    public void Punch()
    {
        player.Components.Animator.TryPlayAnimation("Body_Punch");
        player.Components.Animator.TryPlayAnimation("Legs_Punch");
    }
}
