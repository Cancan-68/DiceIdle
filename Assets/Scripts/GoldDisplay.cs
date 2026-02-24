using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldDisplay : MonoBehaviour
{

    public GameObject goldTextHolder;
    public GameObject gpsTextHolder;
    public Economy economy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldTextHolder.GetComponent<TMP_Text>().text = economy.gold.ToString("F0");
        gpsTextHolder.GetComponent<TMP_Text>().text = economy.goldPerSecond.ToString("F0");
    }
}
