using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour

{
    public Animator transition;
    public float transitionTime = 1f;
    
    // Start is called before the first frame update
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play Anim
        transition.SetTrigger("Start");
        
        //Wait for animation to finish
        yield return new WaitForSeconds(transitionTime);

        //Load level
        SceneManager.LoadScene(levelIndex);
    }
}
