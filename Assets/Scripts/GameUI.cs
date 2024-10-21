using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI coinText;
    public Image image;
    public void Update()
    {
        HienThiThoiGian();
        HienThiCoin();
        HienThiXang();
    }
    public void HienThiThoiGian()
    {
        timeText.SetText(Mathf.FloorToInt(GameManager.Instance.thoiGianChoPhepVeDich).ToString());
    }
    public void HienThiCoin()
    {
        coinText.SetText(Mathf.FloorToInt(GameManager.Instance.soCoin).ToString());
    }

    public void HienThiXang()
    {
        float xRate = GameManager.Instance.soXang / 100f;
        image.fillAmount = xRate;
    }
    public void ChoiLai()
    {
        SceneManager.LoadScene("Game");
    }
    public void VeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
