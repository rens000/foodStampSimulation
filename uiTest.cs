using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiTest : MonoBehaviour
{
  Text text;
  double final = globalVariables.amount * 30;


  void Awake ()
         {
                 text = GetComponent<Text>();
         }

    void Update()
    {
        text.text = " " + final;

    }
}
