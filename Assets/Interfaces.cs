using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IEnemy
{
   public float Health { set; get; }
   public bool IsDeath();
   public void Attacked();
   public void AttackedExit();
}

interface IKillerEnemy
{
   public float Damage {  get; }
}

