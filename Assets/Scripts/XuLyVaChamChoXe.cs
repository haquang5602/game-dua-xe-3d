using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XuLyVaChamChoXe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="CheckPoint")
        {
            GameManager.Instance.QuaCheckPoint();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BH")
        {
            GameManager.Instance.QuaBH();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag =="coin")
        {
            GameManager.Instance.QuaCoin();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "WinPoint")
        {
            
            GameManager.Instance.QuaWinPoint();
        }
    }
}
