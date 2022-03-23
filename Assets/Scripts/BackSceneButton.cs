using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackSceneButton : MonoBehaviour
{
    public Animator transition;
    public float transitionTime=1f;

    void Start(){
        
    }

    void Update(){
       
    }

    public void BackDesktop(){
        SceneManager.LoadScene("AttackerDesktop2");
    }

    public void BackToIndex(){
        SceneManager.LoadScene("IndexScene");
    }

    public void NoTransitionScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void LoadNextScene(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex-1));
    }
    IEnumerator LoadLevel(int levelIndex){
        //Trigger the transition
        transition.SetTrigger("Start");

        //Wait for the transition
        yield return new WaitForSeconds(transitionTime);

        //Change Scene
        SceneManager.LoadScene(levelIndex);
    }
}
