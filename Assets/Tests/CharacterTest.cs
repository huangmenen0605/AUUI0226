
using NUnit.Framework;
using UnityEngine;

public class CharacterTest 
{
    [Test(Description = "角色攻擊敵人")]
    public void Character_Attack_Enemy()
    {
        //arrange
        var go1 = new GameObject();
        go1.AddComponent<Character>();
        var character = go1.AddComponent<Character>();
        character.SetAtk(10);
        
        var go2 = new GameObject();
        go2.AddComponent<Enemy>();
        var enemy = go2.AddComponent<Enemy>();
        enemy.SetHp(100);
        
        //act
        character.Attack(enemy);
        
        //assert
        var hp = enemy.GetHp();
        Assert.AreEqual(90,hp);
    }
    [Test(Description = "角色攻擊敵人，血量最低為0")]
    public void Character_Attack_Dead_Enemy()
    {
        //arrange
        var go1 = new GameObject();
        go1.AddComponent<Character>();
        var character = go1.AddComponent<Character>();
        character.SetAtk(90);
        
        var go2 = new GameObject();
        go2.AddComponent<Enemy>();
        var enemy = go2.AddComponent<Enemy>();
        enemy.SetHp(100);
        
        //act
        character.Attack(enemy);
        character.Attack(enemy);
        
        //assert
        var hp = enemy.GetHp();
        Assert.AreEqual(0,hp);
    }

    [Test(Description = "角色攻擊偵測區域內的所有敵人")]
    public void Character_Attack_All_Triggered_Enemies()
    {
        //arrange
        //玩家角色元件
        var character = new GameObject().AddComponent<Character>();
        character.SetAtk(10);
        //敵人元件
        var enemy1 = new GameObject().AddComponent<Enemy>();
        var enemy1Collider = enemy1.gameObject.AddComponent<BoxCollider2D>();
        enemy1.SetHp(100);
        var enemy2 = new GameObject().AddComponent<Enemy>();
        var enemy2Collider = enemy2.gameObject.AddComponent<BoxCollider2D>();
        enemy2.SetHp(100);
        character.OnTriggerEnter2D(enemy1Collider);
        character.OnTriggerEnter2D(enemy2Collider);

        //act
        character.AttackAllTriggeredEnemies();
        //assert
        Assert.AreEqual(90,  enemy1.GetHp());
        Assert.AreEqual(90 , enemy2.GetHp());
    }
    
}
