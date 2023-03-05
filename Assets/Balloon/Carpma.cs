using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Carpma : MonoBehaviour
{
    public GameObject hedefAlani;
    public GameObject panel;
    private float speed;
    private int score;
    private TextMeshProUGUI scoreText; 
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GameObject.Find("score").GetComponent<TextMeshProUGUI>();
        scoreYazdir();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "HedefAlani")
        {
            hedef();
        }
        else if(collision.gameObject.name == "Zemin")
        {
            float mesafe = Vector3.Distance(transform.position, hedefAlani.transform.position);
            zemin(mesafe);
        }
        else if(collision.gameObject.name == "Leylek")
        {
            leylek();
        }
        else 
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "carpmaKontrol")
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            speed = Mathf.Sqrt(Mathf.Pow(rb.velocity.x,2) + Mathf.Pow(rb.velocity.y, 2) + Mathf.Pow(rb.velocity.z, 2));

            if (speed > 55)
            {
                score -= 70;
            }
            else if (speed <= 55 && speed > 35)
            {
                score -= 40;
            }
            else if (speed <= 35 && speed > 25)
            {
                score -= 20;
            }
            else if (speed <= 25 && speed > 15)
            {
                score += 10;
            }
            else
            {
                score += 20;
            }
        }
        Debug.Log(other.gameObject.name);
        scoreYazdir();
    }

    void hedef()
    {
        
        score += 100;
        scoreYazdir();
        gameOver();
    }

    void zemin(float mesafe)
    {
        score += 100 - (int)mesafe;
        scoreYazdir();
        gameOver();
    }

    void leylek()
    {
        score = 0;
        gameOver();
    }

    void gameOver()
    {
        panel.GetComponent<gameOver>().isGameOver = true;
        gameObject.SetActive(false);
    }
    void scoreYazdir()
    {
        if(score < 0)
        {
            scoreText.SetText("0");
        }
        else
        {
            scoreText.SetText(score.ToString());
        }
        Debug.Log(score);
    }
}
