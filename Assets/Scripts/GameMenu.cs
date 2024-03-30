using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameMenu : MonoBehaviour
{

    public void ReturnHome()
    {
        PhotonNetwork.Disconnect();
    }
}
