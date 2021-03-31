using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void Restart()
    {
        //SceneManager.LoadScene("GameOverScene");
        FindObjectOfType<AudioManger>().StopAllAudio();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
