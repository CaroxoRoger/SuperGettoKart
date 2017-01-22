using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

	public void ChangeToSceneSingle (string name)
    {
        //generalizo para chamar esta funçao seguida de o nome da Scene que quero carregar
        SceneManager.LoadScene(name, LoadSceneMode.Single);
    }
    public void ChangeToSceneAdditive (string name)
    {
        //generaliso para chamar esta funçao seguida de o nome da Scene que quero carregar
        SceneManager.LoadScene(name, LoadSceneMode.Additive);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
