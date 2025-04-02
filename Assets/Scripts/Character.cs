using System;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
  public void AttackAllTriggeredEnemies()
  {
    foreach (var enemy in enemies)
    {
      enemy.TakeDamage(atk);
    }
  }

  private List<Enemy> enemies = new List<Enemy>();

  public void OnTriggerEnter2D(Collider2D collider2D)
  {
    var enemy = collider2D.GetComponent<Enemy>();
    enemies.Add(enemy);

  }

  private int atk;
  public void Attack(Enemy enemy)
  {
    enemy.TakeDamage(atk);
  }

  public void SetAtk(int newatk)
  {
    atk = newatk;
  }

  
}
