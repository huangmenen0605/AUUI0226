using UnityEngine;

public class Enemy : MonoBehaviour
{
   private int hp;
   public void SetHp(int newhp)
   {
      hp = newhp;
   }

   public void TakeDamage(int damage)
   {
      hp = hp - damage;
      if (hp < 0)
      {
         hp = 0;
      }
   }
   
   public int GetHp()
   {
      return hp;
   }
}
