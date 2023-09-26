using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gateScript : MonoBehaviour
{
    EatTarget test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D gate)

    {
        test = new EatTarget();
        print(test.flag);
        if (gate.name == "player")
        {
            if (test.flag == 1)
            {
                SceneManager.LoadSceneAsync(2);
            }


        }



    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
