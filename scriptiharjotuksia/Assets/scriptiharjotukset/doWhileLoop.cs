using UnityEngine;

public class doWhileLoop : MonoBehaviour
{
    void Start()
    {
        RandomDoWhile(0, 10);
    }


    bool bRandomNumber = false;
    int number;

    void RandomDoWhile(int pMinNumber, int pMaxNumber)
    {

        do
        {
            int randomNumber = Random.Range(pMinNumber, pMaxNumber);
            
            if (number < 10 && randomNumber < 3)
            {
                Debug.Log(randomNumber);
                number += randomNumber;
                print("yhteensä");
                Debug.Log(number);


            }
            else if (number >= 10)
            {
                bRandomNumber = true;
                print("valmis");
            }
        }
        while (bRandomNumber == false);

    }
    void Update()
    {

    }
}
