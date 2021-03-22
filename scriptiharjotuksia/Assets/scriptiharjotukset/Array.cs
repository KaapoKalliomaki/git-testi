using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IntArrayReturn();
        print(intTest[2]);

        RandomArray(1, 10);
       


    }


    int[] intTest = new int[3];
    void IntArrayReturn()
    {
        intTest[0] = 23;
        intTest[1] = 45;
        intTest[2] = 52;
        return;
    }


    int randomNumber;
    int[] intArrayRandom = new int[3];
    void RandomArray(int pMinNumber, int pMaxNumber)
    {

        intArrayRandom[0] = randomNumber = Random.Range(pMinNumber, pMaxNumber);
        intArrayRandom[1] = randomNumber = Random.Range(pMinNumber, pMaxNumber);
        intArrayRandom[2] = randomNumber = Random.Range(pMinNumber, pMaxNumber);
        Debug.Log(intArrayRandom[0]);
        Debug.Log(intArrayRandom[1]);
        Debug.Log(intArrayRandom[2]);

        if (intArrayRandom[0] < 5)
        {
            int yhteensä = intArrayRandom[1] + intArrayRandom[2];
            print("yhteensä");
            print(yhteensä);
        }
        else if (intArrayRandom[0] >= 5)
        {
            int yhteensä = intArrayRandom[0] + intArrayRandom[1] + intArrayRandom[2];
            print("yhteensä");
            print(yhteensä);
        }
    }
        
    void FloatArrayTest()
    {
        float[] floatArray = new float[] { };
    }

    void IntArrayTest()
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        print(intArray[2]);
    }

    void StringArrayTest()
    {
        string[] stringArray = { "jorma", "irma", "jussi" };
    }
    // Update is called once per frame
    void Update()
    {

    }

}




