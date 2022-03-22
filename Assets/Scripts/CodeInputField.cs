using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CodeInputField : MonoBehaviour
{
    public InputField CodeInput;

    public void CheckInput(){
        if(CodeInput.text=="RSH247"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
