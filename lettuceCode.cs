using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lettuceCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    globalVariables.amount -= 1.15;
    SceneManager.LoadScene(3);
  }
}
