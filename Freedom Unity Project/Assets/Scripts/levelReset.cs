using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    // If an object collides with an object using this script, the level will restart.
    private void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
