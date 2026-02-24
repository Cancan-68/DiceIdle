using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DiceScript : MonoBehaviour
{
    public Button diceButton;
    public int value;
    public Economy economy;
    /*float multValue;
    float multGPS;
	float lastRolled;
	float numberRolled;
    float[] valueHisto;
	float goldEarnedRoll;
	float totalGoldEarned;*/

    public void Start()
    {
        diceButton.onClick.AddListener(RollDice);
    }

    public void RollDice()
    {
        StartCoroutine(RollDiceCoroutine());
    }

    IEnumerator RollDiceCoroutine()
    {
        // Simulate rolling the dice with he delay
        // Start dice rolling animation
        yield return new WaitForSeconds(10f);
        // Stop dice rolling animation
        int diceRoll = Random.Range(1, value);
        economy.AddGold(diceRoll);
        economy.DisplayGold();
        yield return null;
    }
}
