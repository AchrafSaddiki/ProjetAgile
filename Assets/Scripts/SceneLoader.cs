using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public GameObject tutoPanel ;
    public GameObject creditsPanel ;

	public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void ShowTutorial(){
        tutoPanel.SetActive(true);


    }
    public void HideTutorial(){
          tutoPanel.SetActive(false);




    }
    public void ShowCredits(){
          creditsPanel.SetActive(true);



    }
    public void HideCredits(){
          creditsPanel.SetActive(false);





    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
