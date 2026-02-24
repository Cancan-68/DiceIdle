using UnityEngine;

public class Player : MonoBehaviour
{

    public Economy economy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        economy.AddGoldPerSecond();
    }
}
