
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
    
}
