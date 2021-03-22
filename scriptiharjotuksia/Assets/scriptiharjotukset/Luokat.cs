using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luokat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Practise
{

    int health = 100;

    void SetHealth(int pDamage)
    {

        health -= pDamage;
    }

    int GetHealth()
    {
        return health;

    }

}