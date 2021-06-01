using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Selected : MonoBehaviour
{
    [SerializeField]
    private GameObject selected = default;
    GameObject start,end;

    EventSystem ev;
    GameObject g;

    void Start()
    {
        start = GameObject.Find("Canvas/selectBtn/start");
        end = GameObject.Find("Canvas/selectBtn/end");
    }
    void Update()
    {
        ev = EventSystem.current;
        g = ev.currentSelectedGameObject;
        
        if(g==start)
        {
            selected.GetComponent<RectTransform>().anchoredPosition= new Vector2(160f, -50f);
        }
        if(g==end)
        {
            selected.GetComponent<RectTransform>().anchoredPosition= new Vector2(160f, -100f);
        }
    }
    public void OnClick()
    {
        if(g==start)
        {
            SceneManager.LoadScene("Game");
        }
        if(g==end)
        {
            Quit();
        }
    }
    void Quit() {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
        UnityEngine.Application.Quit();
        #endif
  }
}
