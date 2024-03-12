using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
	public class DialogueBaseSystem : MonoBehaviour
	{
		public bool finished { get; private set; }

		protected IEnumerator WriteText(string input, Text textHolder, Color textColor, Font textFont, float delay, AudioClip sound, float delayBetweenLines)
		{
			textHolder.color = textColor;
			textHolder.font = textFont;

			for(int i = 0; i < input.Length; i++)
			{
				if (Input.GetKey(KeyCode.X))
				{
					for(int j = i; j < input.Length; j++)
					{
						textHolder.text += input[j];
					}
					i = input.Length - 1;
				}
				textHolder.text += input[i];
				SoundManager.instance.PlaySound(sound);
				yield return new WaitForSeconds(delay);
			}
			yield return new WaitUntil(() => Input.GetKey(KeyCode.Z));

			finished = true;
		}
	}
}
