using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //�̱���
    public static GameManager instance;
    //�ð�����
    public float time = 600.0f;
    public float re_time = 600.0f;
    //��������
    [HideInInspector] public int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        TimeCountUp();
    }


    void TimeCountUp()
    {
        time -= Time.deltaTime;
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}
