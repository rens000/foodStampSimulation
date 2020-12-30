using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class orangeCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    globalVariables.amount -= .85;
    SceneManager.LoadScene(2);
  }
}
