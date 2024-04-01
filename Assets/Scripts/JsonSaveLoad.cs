using UnityEngine;
using System.Collections.Generic;

public class JsonSaveLoad : MonoBehaviour
{
    public Inventory inventory = new Inventory();

	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveToJson();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadFromJson();
        }
	}

	public void SaveToJson()
    {
        string inventoryData = JsonUtility.ToJson(inventory); // Json���� ����ȭ
        string filePath = Application.persistentDataPath + "/InventoryData.json";
        Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, inventoryData);
        Debug.Log("??");
    }

    public void LoadFromJson()
    {
		string filePath = Application.persistentDataPath + "/InventoryData.json";
        string inventoryData = System.IO.File.ReadAllText(filePath);

        inventory = JsonUtility.FromJson<Inventory>(inventoryData);
        Debug.Log("!!");
	}
}

[System.Serializable]
public class Inventory
{
    public int goldCoins;
    public bool isFull;
    public List<Items> items = new List<Items>();
}

[System.Serializable]
public class Items
{
    public string name;
    public string desc;
}

