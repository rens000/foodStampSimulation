using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class potatoCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    globalVariables.amount -= 1.21;
    SceneManager.LoadScene(4);
  }
}
