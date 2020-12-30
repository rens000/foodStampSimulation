using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class appleCode : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
      globalVariables.amount -= .90;
      SceneManager.LoadScene(2);
    }
}
