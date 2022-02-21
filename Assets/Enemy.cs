using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour , IEnemy
{
    
    [SerializeField] private float maxHp;
    [SerializeField] private SpriteRenderer sprite;
    private float hp;
    
    public bool IsDeath() => hp <= 0;
    
    public void Attacked()=> sprite.color = Color.red;
    public void AttackedExit()=> sprite.color = Color.yellow;


    public float Health
    {
        get => hp;
        set
        {
            hp = value;
            if (IsDeath())
                Destroy(gameObject);
            

        } 
    }

    private void Start()=> Health = maxHp;
    
}
