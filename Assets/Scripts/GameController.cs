using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject panelEndGame;
    public Button Restart;
    AudioSource audio;
   // public Sprite Idle;
   // public Sprite Hover;
   // public Sprite Click;
    public Text Point;
    private int gamePoint;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        panelEndGame.SetActive(false);
        audio = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetPoint()
    {
        gamePoint++;
        Point.text = "Point : " + gamePoint;
    }

    /*
    public void ButtonHover()
    {
        Restart.GetComponent<Image>().sprite = Hover;
    }

    public void ButtonIdle()
    {
        Restart.GetComponent<Image>().sprite = Idle;
    }

    public void ButtonClick()
    {
        Restart.GetComponent<Image>().sprite = Click;
    }
    */

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void _EndGame()
    {
        audio.Play();
        Time.timeScale = 0;
        panelEndGame.SetActive(true);
    }
}
