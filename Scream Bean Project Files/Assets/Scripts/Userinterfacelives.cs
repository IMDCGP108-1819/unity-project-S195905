using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Userinterfacelives : MonoBehaviour {

    //This script keeps track of lives and prevents the number of lives from going into the negative figures. Functions that were originally intended to go in here went to other scripts

    Text text;
    public static int liveAmount = 20;
  

    void Start()
    {

        text = GetComponent<Text>();
        

    }

    void Update()
    {

        text.text = liveAmount.ToString();
        Mathf.Clamp(liveAmount, 0, 21);

        if (liveAmount >= 1)
        {

            
        }

        {


        }

       if (liveAmount <= 1)
        {
           
            
           
        }

    }


        void Restart ()
    {

       

    }
}
