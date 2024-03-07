using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
	public class DialogueLine : DialogueBaseSystem
	{
		private Text textHolder;

		[Header("Text Options")]
		[SerializeField] string input;
		[SerializeField] Color textColor;
		[SerializeField] Font textFont;

		[Header("Time parameters")]
		[SerializeField] float delay;
		[SerializeField] float delayBetweenLines;

		[Header("Sound")]
		[SerializeField] AudioClip sound;

		[Header("Character Image")]
		[SerializeField] Sprite characterSprite;
		[SerializeField] Image imageHolder;

		private void Awake()
		{
			textHolder = GetComponent<Text>();
			textHolder.text = "";

			imageHolder.sprite = characterSprite;
			imageHolder.preserveAspect = true;
		}

		private void Start()
		{
			StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay, sound, delayBetweenLines));
		}
	}
}


