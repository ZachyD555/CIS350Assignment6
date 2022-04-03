using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 125;

        GameManager.instance.score += 5;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacked!");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took " + amount + " points of damage!");
    }

    void Update()
    {
        
    }
}
