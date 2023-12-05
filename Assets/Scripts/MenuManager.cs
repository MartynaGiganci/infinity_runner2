using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Text coinsValue;
    public Text soundBtnText;
    int coins = 0;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        coinsValue.text = coins.ToString();
        if (SoundManager.instance.GetMuted())
        {
            soundBtnText.text = "TURN ON SOUND";
        }
        else
        {
            soundBtnText.text = "TURN OFF SOUND";
        }
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void SoundButton()
    {
        SoundManager.instance.ToggleMuted();
        UpdateUI();
    }
}
