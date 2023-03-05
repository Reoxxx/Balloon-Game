using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI restartText;
    public bool isGameOver;
    private bool kontrol;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        restartText.gameObject.SetActive(false);
        isGameOver = false;
        kontrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            if (kontrol)
            {
                
                gameOverText.gameObject.SetActive(true);
                restartText.gameObject.SetActive(true);
                kontrol=false;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                print("Application Quit");
                Application.Quit();
            }

            
        }
    }
}
