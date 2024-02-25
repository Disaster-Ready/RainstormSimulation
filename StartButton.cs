using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;
    public Slider magSlider;
    public GameManager gameManager;

    private void Start()
    {
        magSlider = magSlider.GetComponent<Slider>();
        startButton.onClick.AddListener(StartStorm);
    }

    public void StartStorm()
    {
        Debug.Log("START BUTTON CLICKED");

        gameManager.stormStrength = magSlider.value*100;
        gameManager.StartStorm();
    }
}


