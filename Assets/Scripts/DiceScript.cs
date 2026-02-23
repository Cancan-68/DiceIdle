using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    public Button RollDiceButton, OpenShopButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RollDiceButton.onClick.AddListener(RollDice);
        OpenShopButton.onClick.AddListener(() => Debug.Log("Shop opened!")); // Placeholder for shop opening logic
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RollDice()
    {
        int diceRoll = Random.Range(1, 7); // Generates a random number between 1 and 6
        Debug.Log("You rolled a " + diceRoll);
        // You can add additional logic here to handle the result of the dice roll
    }
}
