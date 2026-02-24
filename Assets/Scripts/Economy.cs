using UnityEngine;

[CreateAssetMenu(fileName = "Economy", menuName = "Scriptable Objects/Economy")]
public class Economy : ScriptableObject
{
    public float gold;
    public float goldPerSecond;

    public void AddGold(float amount)
    {
        gold += amount;
    }

    public void AddGoldPerSecond()
    {
        gold += goldPerSecond * Time.deltaTime;
    }

    public void DisplayGold()
    {
        Debug.Log("Current Gold: " + gold);
    }
}
