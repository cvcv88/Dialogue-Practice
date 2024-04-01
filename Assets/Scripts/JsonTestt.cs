using UnityEngine;
using Newtonsoft.Json;
using System;
[Serializable]
public class TestClass002
{
	public int id;
	public int value;
	public bool boolean;
}

public class JsonTestt : MonoBehaviour
{
	/*
	public TestClass002[] TestVariable;
	private void Start()
	{
		// var result = JsonConvert.SerializeObject(TestVariable);
		var result = JsonConvert.SerializeObject(TestVariable); //Convert to json
		Debug.Log(result);
	}
	*/

	public TextAsset JsonFile;//Variable that contains json data
	private void Start()
	{
		var result = JsonConvert.DeserializeObject<TestClass002[]>(JsonFile.text); //convert to usable data
		foreach (var i in result)
		{
			Debug.Log($"Id : {i.id}, Value : {i.value}, Bool : {i.boolean}"); //Print data;
		}
	}

}

