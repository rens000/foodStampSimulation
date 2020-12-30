using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class eggCode : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
      globalVariables.amount -= .25;
      SceneManager.LoadScene(5);

}

}
