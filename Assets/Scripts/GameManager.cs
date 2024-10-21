using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float thoiGianChoPhepVeDich = 40f;
    public bool ketThucGame = false;
    public bool winGame = false;
    private static GameManager instance;
    public GameObject gameOverObject;
    public GameObject timeGame;
    public GameObject coin;
    public Image coinImage;
    public Image Image1;
    public GameObject Xang;
    [SerializeField]
    private float thoiGianCongThem = 10f;
    [SerializeField]
    public float soXang = 100f;
    public GameObject winGameObject;
    public float soCoin = 30f;



    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject gameManagerGameObject = new GameObject("GameManager");
                    instance = gameManagerGameObject.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }
    private void Update()
    {
        if (!ketThucGame)
        {
            thoiGianChoPhepVeDich -= Time.deltaTime;
            soXang -= 0.01f;
            //Debug.Log(thoiGianChoPhepVeDich);
            if (thoiGianChoPhepVeDich <= 0 || soXang <= 0) 
            {
                KetThucGame();
                gameOverObject.SetActive(true);
                timeGame.SetActive(false);
                coin.SetActive(false);
                coinImage.enabled = false;
                Image1.enabled = false;
                Xang.SetActive(false);
            }
        }
        if (winGame)
        {
            timeGame.SetActive(false);
            winGameObject.SetActive(true);
            coin.SetActive(true);
            Image1.enabled = false;
            Xang.SetActive(false);
        }
    }
    private void KetThucGame()
    {
        ketThucGame = true;
    }
    public void QuaBH()
    {
        if (!ketThucGame)
        {

            soXang += 15;
            Debug.Log(soXang);

        }
    }
    public void QuaCoin()
    {
        if (!ketThucGame)
        {
            soCoin += 1;
            Debug.Log(soCoin);
        }
    }

    public void QuaCheckPoint()
    {
        if (!ketThucGame)
        {
            thoiGianChoPhepVeDich += thoiGianCongThem;
        }
    }
    public void QuaWinPoint()
    {
        if (!ketThucGame)
        {
            winGame = true;
        }
    }
}
