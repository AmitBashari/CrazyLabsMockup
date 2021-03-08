using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public AnimationClip KnifeAnim;
    public StoryEngine StoryEngine;
    public StoryScreen StoryScreen;

    public static bool ToShowNextLine;

    private Animator _knifeAnimator;
    private bool ToGoNextLine;

    // Start is called before the first frame update
    void Start()
    {
        _knifeAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Slice();   
    }

    private void Slice()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _knifeAnimator.SetTrigger("isActive");
        }
    }

}
