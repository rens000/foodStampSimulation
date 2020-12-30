using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class strawberryCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
      globalVariables.amount -= 1.64;
      SceneManager.LoadScene(2);}


}
