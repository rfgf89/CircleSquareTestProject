using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CircleDestroyer : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private int maxDestroyCicrcleToWin;
    
    [SerializeField] private UnityEvent victoryEvent;
    
    private int destroyCicrcleToWin;


    void OnCollisionStay2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<IEnemy>();

        if (enemy != null)
        {
            enemy.Health -= damage;
            enemy.Attacked();
            if (enemy.IsDeath())
            {
                destroyCicrcleToWin++;
                if (destroyCicrcleToWin >= maxDestroyCicrcleToWin)
                    victoryEvent.Invoke();
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision) => collision.gameObject.GetComponent<IEnemy>()?.AttackedExit();
        
    
}
