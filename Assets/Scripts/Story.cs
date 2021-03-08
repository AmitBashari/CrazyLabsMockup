using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Story Object")]
public class Story : ScriptableObject
{
    public string StoryName;
    [TextArea(5, 15)]
    public string Plot;
    public Story NextSentence;
    public bool IsLastSentence;
}
