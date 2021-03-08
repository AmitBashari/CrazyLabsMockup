using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryEngine : MonoBehaviour
{
    public StoryScreen Screen;
    public Story InitialLine;
    public SceneLoader SceneLoader;


    private float _loadDelay = 8f;
    void Start()
    {
        LoadStory(InitialLine);
    }

    public void LoadStory(Story story)
    {
        Screen.Setup(story);
    }

    private void LoadLevelComplete()
    {
        SceneLoader.LoadNextScene();
    }

    private void Update()
    {
       if (Screen.CurrentStory.IsLastSentence == true)
        {
            Invoke("LoadLevelComplete", _loadDelay);
        }

    }
}
