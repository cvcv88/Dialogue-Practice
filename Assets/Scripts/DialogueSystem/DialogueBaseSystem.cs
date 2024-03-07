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
				textHolder.text += input[i];
				// play letter sound
				SoundManager.instance.PlaySound(sound);
				yield return new WaitForSeconds(delay);
			}
			// yield return new WaitForSeconds(delayBetweenLines);
			yield return new WaitUntil(() => Input.GetMouseButton(0));

			finished = true;
		}
	}
}