using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FirstPlatform : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinText;
    bool _destroy = true;
    private void OnTriggerEnter(Collider other)
    {
        //_destroy = true;

        if (other.gameObject.tag == "Board")
        {
            DestroyBoard(other.gameObject);
            _destroy = false;
            if (playerData.Instance._childCount == 0)
            {
                playerData.Instance._stop = true;
                UIManager.Instance.openWinGamecanvas();
                _coinText.text = playerData.Instance._coinCount + "";
            }

          //  playerData.Instance.setCoinCount(playerData.Instance._coinCount * 2);
        }
    }

    private void DestroyBoard(GameObject gameObject)
    {
        if (_destroy)
        {
            Destroy(gameObject);
            playerData.Instance._childCount -= 1;
            _destroy = false;
        }
    }
}
