using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject continuePanel;
    bool cont = false;

    void Start()
    {
        continuePanel.SetActive(false);
        cont = false;
    }
    void Update()
    {
        if(cont)
        {
            if(Input.GetKey(KeyCode.Return))
            {
                Retry();
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Dead();
        }
        Destroy(col.gameObject);
    }
    public void Dead()
    {
        cont = true;
        continuePanel.SetActive(true);
    }
    void Retry()
    {
        SceneManager.LoadScene("Game");
    }
}
