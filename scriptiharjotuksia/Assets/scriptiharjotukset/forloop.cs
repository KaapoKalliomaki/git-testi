using UnityEngine;

public class forloop : MonoBehaviour
{
    // Start is called before the first frame update

    int forMuuttuja;
    int number = 5;
    int condition = 20;


    void Start()
    {
        for (forMuuttuja = 0; forMuuttuja <= condition; forMuuttuja += number)
        {
            Debug.Log(forMuuttuja);
            
        }

        for (int i = 0; i > 10; i++)
        {

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Action()
    {

    }

}
