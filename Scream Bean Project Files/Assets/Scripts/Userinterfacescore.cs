using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Userinterfacescore : MonoBehaviour {

    Text text;
    public static int scoreAmount = 0;
 

    void Start()
    {
        text = GetComponent<Text>();
    }



    void Update()
{

    text.text = scoreAmount.ToString();
}

}