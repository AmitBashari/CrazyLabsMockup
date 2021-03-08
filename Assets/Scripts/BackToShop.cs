using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToShop : MonoBehaviour
{
    public GameObject AdPannel;
    public GameObject ShopPannel;

    public void BackToShopMenu()
    {
        AdPannel.SetActive(false);
        ShopPannel.SetActive(true);
    }
}
