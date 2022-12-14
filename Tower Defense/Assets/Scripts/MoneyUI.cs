using UnityEngine.UI;
using UnityEngine;
using TMPro;



public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Cybucks :" + PlayerStats.money.ToString();
    }
}
