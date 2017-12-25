﻿using UnityEngine;
using System.Collections;
using UnityEngine.Events;
//using UnityEngine.UI;

public class StartHover : MonoBehaviour {

	public char theText;

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        Text highScore = GameObject.Find("HighScore chiffre").GetComponent<Text>();
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
    }

	/*public void OnPointerEnter(PointerEventData enventData)
	{
		theText.color = Color.blue;
	}

	public void OnPointerExit(PointerEventData eventData) 
	{
		theText.color = Color.black;
	}*/

}
