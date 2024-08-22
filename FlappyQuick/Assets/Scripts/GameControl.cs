using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour 
{
    public static GameControl instance;
    public GameObject gameOverText;
    public TextMeshProUGUI ScoreText;
    public Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

   

    private int score = 0;

    void Start()
    {
       
    }


    // Start is called before the first frame update
    void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }


  
}


