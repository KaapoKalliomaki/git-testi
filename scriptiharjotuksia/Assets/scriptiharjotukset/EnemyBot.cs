using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBot : MonoBehaviour
{
    string botName;
    int health;
    int damage;
    public EnemyBot(string pName, int pHealth, int pDamage)
    {
        this.botName = pName;
        this.health = pHealth;
        this.damage = pDamage;
    }

    EnemyBot ebot1 = new EnemyBot("ebot1", 100, 20);
    EnemyBot ebot2 = new EnemyBot("ebot2", 100, 25);

    // Start is called before the first frame update
    void Start()
    {
        print("blöblö");
        ebot1.Battle();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Attack(EnemyBot target)
    {
        target.health -= this.damage;
    }
    public void Battle()
    {
        while (ebot1.health > 0 && ebot2.health > 0)
        {
            ebot1.Attack(ebot2);
            ebot2.Attack(ebot1);

            if (ebot1.health <= 0)
            {
                print("the winner is");
                print(ebot2.botName);
                break;

            }
            if (ebot2.health <= 0)
            {
                print("the winner is");
                print(ebot1.botName);
                break;
            }
        }

    }


}