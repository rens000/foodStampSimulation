using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cornCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    globalVariables.amount -= 1.14;
    SceneManager.LoadScene(3);
  }
}
