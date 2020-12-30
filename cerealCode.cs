using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cerealCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    globalVariables.amount -= .78;
    SceneManager.LoadScene(4);
  }
}
