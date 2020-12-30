using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class peanutCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    globalVariables.amount -= .74;
    SceneManager.LoadScene(5);
}
}
