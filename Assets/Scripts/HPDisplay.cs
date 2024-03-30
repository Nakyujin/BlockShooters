using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class HPDisplay : MonoBehaviour
{
    [SerializeField] PhotonView playerPV;
    [SerializeField] GameObject myHpImage;

    void Start()
    {
        if(playerPV.IsMine)
        {
            myHpImage.SetActive(false);
        }
    }
}
