using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class endDisplay : MonoBehaviour
{
  void Start() {
    StartCoroutine (loadSceneAfterDelay(20));

    }

    IEnumerator loadSceneAfterDelay(float waitbySecs){

        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene(6);

  }

}
