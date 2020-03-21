using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{
    public float respawnDelay;
    public Playercontroller gamePlayer;
    public int coin;
    public Text coinText;

    // Use this for initialization
    void Start()
    {
        gamePlayer = FindObjectOfType<Playercontroller>();
        coinText.text = "Coins: " + coin;

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Respawn()
    {
        StartCoroutine("RespawnCoroutine");

    }
    public IEnumerator RespawnCoroutine()
    {
        gamePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        gamePlayer.transform.position = gamePlayer.respawnPoint;
        gamePlayer.gameObject.SetActive(true);
    }
    public void AddCoin(int numberOfCoins)
    {
        coin += numberOfCoins;
        coinText.text = "Coins: " + coin;

    }
}
