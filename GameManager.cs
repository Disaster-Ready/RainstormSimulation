using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isStormStarted = false;
    public float stormStrength = 0;
    public StormController stormController;

    public GameObject openingScreenSelection;
    public GameObject experimentModeUI;
    public GameObject storylineModeUI;
    public GameObject storylineEnd;

    public GameObject questionOne;
    public GameObject questionTwo;
    public GameObject questionThree;
    public GameObject questionFour;
    public GameObject questionFive;

    private WaitForSeconds delay = new WaitForSeconds(1f);

    private void Start()
    {
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive(false);
        questionThree.SetActive(false);
        storylineEnd.SetActive(false);
        questionFour.SetActive(false);
        questionFive.SetActive(false);

        stormStrength = 0; 
        ShowOpeningScreenSelection();
    }

    public void StartStormStoryline()
    {
        stormStrength = 3f;
        isStormStarted = true;
        if (stormController != null)
        {
            stormController.StartStorm();
        }
        Debug.Log("Storm Starting.");
    }

    public void StartStorm()
    {
        isStormStarted = true;
        if (stormController != null)
        {
            stormController.currentStrength = stormStrength;
            stormController.StartStorm();
            
        }
        Debug.Log("Storm Starting.");
    }

    public void StopStorm()
    {
        stormStrength = 0;
        if (stormController != null)
        {
            stormController.StopStorm();
        }
    }

    public void ShowOpeningScreenSelection()
    {
        openingScreenSelection.SetActive(true);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
    }

    public void SelectExperimentMode()
    {
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(true);
        storylineModeUI.SetActive(false);
    }

    public void SelectStorylineMode()
    {
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(true);
        Debug.Log("Selected Storyline Mode");
    }

    public void BeginStorylineMode()
    {
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive(false);
        questionThree.SetActive(false);
        questionFour.SetActive(false);
        questionFive.SetActive(false);
        storylineEnd.SetActive(false);
        StartStormStoryline();
        ShowQuestionOne();
    }

    public void ShowQuestionOne()
    {
        StartCoroutine(ShowQuestionOneTrue());
    }

    public IEnumerator ShowQuestionOneTrue()
    {
        yield return delay;
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(true);
        questionTwo.SetActive(false);
        questionThree.SetActive(false);
        questionFour.SetActive(false);
        questionFive.SetActive(false);
        storylineEnd.SetActive(false);
    }

    public void ShowQuestionTwo()
    {
        StartCoroutine(ShowQuestionTwoTrue());
    }

    public IEnumerator ShowQuestionTwoTrue()
    {
        yield return delay;
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive(true);
        questionThree.SetActive(false);
        questionFour.SetActive(false);
        questionFive.SetActive(false);
        storylineEnd.SetActive(false);
    }

    public void ShowQuestionThree()
    {
        StartCoroutine(ShowQuestionThreeTrue());
    }

    public IEnumerator ShowQuestionThreeTrue()
    {
        yield return delay;
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive(false);
        questionThree.SetActive(true);
        questionFour.SetActive(false);
        questionFive.SetActive(false);
        storylineEnd.SetActive(false);
    }

    public void ShowQuestionFour()
    {
        StartCoroutine(ShowQuestionFourTrue());
    }

    public IEnumerator ShowQuestionFourTrue()
    {
        yield return delay;
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive(false);
        questionThree.SetActive(false);
        questionFour.SetActive(true);
        questionFive.SetActive(false);
        storylineEnd.SetActive(false);
    }

    public void ShowQuestionFive()
    {
        StartCoroutine(ShowQuestionFiveTrue());
    }

    public IEnumerator ShowQuestionFiveTrue()
    {
        yield return delay;
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive (false);
        questionThree.SetActive (false);
        questionFour.SetActive (false);
        questionFive.SetActive (true);
        storylineEnd.SetActive(false);
    }

    public void ShowStorylineEnd()
    {
        StartCoroutine(ShowStorylineEndTrue());
    }

    public IEnumerator ShowStorylineEndTrue()
    {
        yield return delay;
        openingScreenSelection.SetActive(false);
        experimentModeUI.SetActive(false);
        storylineModeUI.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive(false);
        questionThree.SetActive(false);
        questionFour.SetActive(false);
        questionFive.SetActive(false);
        storylineEnd.SetActive(true);
    }

    public void RestartSimulation()
    {
        StartCoroutine(RestartSimulationTrue());
    }

    public IEnumerator RestartSimulationTrue()
    {
        yield return delay;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
