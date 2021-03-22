using UnityEngine;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Muuttujat
    int health = 100;
    bool aboveHalfHealth = true;
    bool belowHalfHealth = false;
    bool isDead = false;
    bool endGame = false;
    float number;

    void Harjotus1()
    {
        if (health >= 50)
        {
            aboveHalfHealth = true;
            belowHalfHealth = false;
            isDead = false;
        }
        else if (health >= 1 && health < 50)
        {
            aboveHalfHealth = false;
            belowHalfHealth = true;
            isDead = false;
        }
        else
        {
            aboveHalfHealth = false;
            belowHalfHealth = false;
            isDead = true;
        }
        if (isDead == true)
        {
            endGame = true;
        }
    }

    bool ramdomNumberBigger = false;
    void Jotain(int pMinNumber, int pMaxNumber)
    {

        int randomNumber = Random.Range(pMinNumber, pMaxNumber);

        if (randomNumber > 5)
        {
            ramdomNumberBigger = true;

        }

    }

    string description = "";

    string TextMethod()
    {
        if (description == "yes")
        {
            description = "no";
            return description;
        }
        else
        {
            description = "yes";
            return description;
        }
    }



    void Formuuttuja()
    {
        int forMuuttuja;

        for (forMuuttuja = 0; forMuuttuja >= 10; forMuuttuja++)
        {
            Debug.Log(forMuuttuja);
        }

    }


    // Update is called once per frame
    void Update()
    {

    }

    void TakeDamage(int pDamage)
    {
        health -= pDamage;
    }

    int GetHealth()
    {

        return health;
    }

    int CreateNumber(int firstNumber, int secondNumber)
    {
        int theNumber;

        if (firstNumber >= 1 && secondNumber >= 1)
        {
            theNumber = firstNumber + secondNumber;
            return theNumber;
        }
        else
        {
            theNumber = firstNumber - secondNumber;
            return theNumber;
        }


    }

    void GameMethod()
    {
        TakeDamage(34);
        int uhjdweqfkhjfdweuhj = GetHealth();

        int newNumber = CreateNumber(3, 6);
        int newNumber2 = CreateNumber(33, 55);

        int randomNumber1 = CreateNumber(Random.Range(-5, 10), Random.Range(-5, 10));

    }

}




