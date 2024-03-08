using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. 데이터(코드 = 클래스)를 만들어야함. => 저장할 데이터 생성
// 2. 그 데이터를 Json으로 변환.
// =============================
// 3. Json을 다시 원래 코드로 바꾸는 방법
// Json -> 조립 -> 클래스(코드)

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
    Data player = new Data() { nickname = "유정", level = 275, coin = 200, skill = false };

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
