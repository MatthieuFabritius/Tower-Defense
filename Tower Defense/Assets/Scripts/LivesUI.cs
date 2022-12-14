using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour

{
    public TextMeshProUGUI livesText;


    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerStats.lives + " LIVES";
    }
}
