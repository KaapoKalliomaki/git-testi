using UnityEngine;

public class randomNumberloop : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        print("Päivää Mr.Stark");
        RandomNumberLoop(0, 10);
    }

    bool randomNumberBigger = false;
    int randomNumber;
    void RandomNumberLoop(int pMinNumber, int pMaxNumber)
    {
        while (randomNumberBigger == false)
        {
            randomNumber = Random.Range(pMinNumber, pMaxNumber);
            print(randomNumber);
            if (randomNumber > 5)
            {
                randomNumberBigger = true;
                print("I did it!");
                
            }
        }
    }
}

