using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. ������(�ڵ� = Ŭ����)�� ��������. => ������ ������ ����
// 2. �� �����͸� Json���� ��ȯ.
// =============================
// 3. Json�� �ٽ� ���� �ڵ�� �ٲٴ� ���
// Json -> ���� -> Ŭ����(�ڵ�)

class Data
{
    public string nickname;
    public int level;
    public int coin;
    public bool skill;
    // public string[] scripts;
}

public class Test : MonoBehaviour
{
    Data player = new Data() { nickname = "����", level = 275, coin = 200, skill = false };

    // Start is called before the first frame update
    void Start()
    {
        string jsonData = JsonUtility.ToJson(player);

        // print(jsonData);

        Data player2 = JsonUtility.FromJson<Data>(jsonData);
        print(player2.nickname);
		print(player2.level);
		print(player2.coin);
		print(player2.skill);

	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
