using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScreen : MonoBehaviour
{
    public StoryEngine Engine;
    public Story CurrentStory;
    public Story NextStoryLine;
    public Text Line;

    private float _delayText = 1.5f;

    public void Setup(Story story)
    {
        CurrentStory = story;
        NextStoryLine = story.NextSentence;
        Line.text = story.Plot;
        Debug.Log("I Setup");
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("ShowNextLine", _delayText);
        }
       
    }

    public void ShowNextLine()
    {
            Engine.LoadStory(NextStoryLine);
    }
}
