using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chickenCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    globalVariables.amount -= 1.99;
    SceneManager.LoadScene(5);
}
}
