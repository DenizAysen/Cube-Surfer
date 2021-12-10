using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject explosionPrefab;
    AudioSource _audioSource;
    int coin;
    void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
        coin = playerData.Instance.getCoinCount();
    }

    // Update is called once per frame
    public void Explode()
    {
        playerData.Instance._coinCount += 1;
        //playerData.Instance.setCoinCount(coin);
        PlayVoice();
        if (explosionPrefab)
        {
            // Instantiate an explosion effect at the gameObjects position and rotation
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
        Destroy(gameObject,0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Board")
        {
            Explode();
        }
    }

    private void PlayVoice()
    {
        _audioSource.Play();
    }
}
