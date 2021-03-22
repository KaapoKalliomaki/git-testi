using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suojaus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StaticClass.StaticMethod(1, 2);
    }

    public static class StaticClass
    {
        static int tulos;

        public static void StaticMethod(int pNumber1, int pNumber2)
        {
            tulos = pNumber1 + pNumber2;
            print(tulos);
        }
    }

   class Base
    {
        protected int numero1;
        protected int randomNumero;
        protected int SuojattuMetodi(int pNumber1, int pNumber2)
        {
            numero1 = pNumber1 * pNumber2;
            return numero1;
        } 
        
        protected int RandomNumber(int pMinNumber, int pMaxNumber)
        {
            int randomNumber = Random.Range(pMinNumber, pMaxNumber);
            Debug.Log(randomNumber);
            randomNumero = randomNumber;
            return randomNumber;

        }

    }
    class Inheritor : Base
    {

        int numero2 = 5;
        protected class Konstruktori : Inheritor
        {
            public Konstruktori(int pNumero2, int pRandomNumero )
            {
                
                numero2 = pNumero2;
                randomNumero = pRandomNumero;
            }
            
        }

    }

    class Other : Inheritor
    {
        void Main()
        {

            Konstruktori olio = new Konstruktori(2, RandomNumber(0, 10));
        }
    }
    }

