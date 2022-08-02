using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth
{
    private Player player;

    private int currentHealth;

    public PlayerHealth(Player player)
    {
        this.player = player;
    }

    public void SetMaxHealth(int health)
    {
        player.Components.Slider.maxValue = health;
        player.Components.Slider.value = health;
    }

    public void SetHealth(int health)
    {
        player.Components.Slider.value = health;
    }
}
