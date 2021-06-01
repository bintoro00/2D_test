using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Event : MonoBehaviour
{
    private bool event_a = false;
    public PlayerController playerController;
    [SerializeField]
    private GameObject ComPanel = default;
    [SerializeField]
    private Text MessageTxt = default, CharNameTxt = default;
    void Start()
    {
        ComPanel.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            event_a = true;
            Event_A_Start(event_a);
        }
    }
    void Event_A_Start(bool flag)
    {
        if(flag)
        {
            playerController.isMove = false;
            ComPanel.SetActive(true);
            MessageTxt.text = "...";
            CharNameTxt.text = "？？？";

            
        }
    }
}
