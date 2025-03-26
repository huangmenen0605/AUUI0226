using UnityEngine;

public class Character : MonoBehaviour
{
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
