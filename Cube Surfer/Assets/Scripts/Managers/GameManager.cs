using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : singleton<GameManager>
{
    // Start is called before the first frame update
   // PlayerController PlayerController;
    //public bool _isWinned = false;
    private void Start()
    {
        playerData.Instance._stop = true;
       // PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if (parmak.phase == TouchPhase.Began)
            {
                playerData.Instance._stop = false;
                UIManager.Instance.PreGameCanvas.enabled = false;               
                gameObject.SetActive(false);
                //   _isWaitingToStart = false;
                // StopCoroutine(_coroutine);
                //  _waitText.enabled = false;
                //  _swipeImage.enabled = false;
                //   gameState.enabled = true;
                //   playerController.enabled = true;

            }
        }
    }
    public void LoseGame()
    {      
        //    PlayerController.enabled = false;        
    }

    public void WinGame()
    {
       
      // PlayerController.enabled = false;
    }

   
}
