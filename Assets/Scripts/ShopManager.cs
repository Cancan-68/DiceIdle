using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    public Economy economy;
    public GameObject shopMenu;
    public Button openShopButton;
    public Button closeShopButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        openShopButton.onClick.AddListener(ToggleShopMenu);
        closeShopButton.onClick.AddListener(ToggleShopMenu);
    }

    void ToggleShopMenu()
    {
        shopMenu.SetActive(!shopMenu.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
