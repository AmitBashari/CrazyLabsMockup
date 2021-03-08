using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchAds : MonoBehaviour
{
    public GameObject AdPannel;
    public GameObject ShopPannel;

    public void WatchAdPannel()
    {
        ShopPannel.SetActive(false);
        AdPannel.SetActive(true);
    }

    public void UnlockStoryKnife()
    {

    }
}
