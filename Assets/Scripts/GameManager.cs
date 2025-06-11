using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public string name;
    public Sprite portrait;
    public int level;
    public int exp;
    public string title;
    public string description;
    public int gold;
    public int ap;
    public int dp;
    public int hp;
    public int cp;
}

public class GameManager : MonoBehaviour
{
    public List<CharacterData> dataList;
    public static GameManager Instance { get; private set; }
    public Character player { get; private set; }

    [SerializeField] private int curDataNum = 0;

    [SerializeField] private GameObject playerPrefab;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        SetData(dataList[curDataNum]);
    }

    private void Update()
    {
        SetData(dataList[curDataNum]);
    }

    public void ChangeDataNum(int num)
    {
        curDataNum = num;
    }

    /// <summary>
    /// �÷��̾ ������ �����ϰ� �÷��̾� ������ data�� ���� �ʱ�ȭ
    /// </summary>
    /// <param name="data"></param>
    public void SetData(CharacterData data)
    {
        if (player == null)
        {
            GameObject playerObj = Instantiate(playerPrefab);
            player = playerObj.GetComponent<Character>();
        }
        else
        {
            player = FindObjectOfType<Character>();
        }
            player.InitPureStatus(data);
    }
}
