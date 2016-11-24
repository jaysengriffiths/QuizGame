using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public List<RoundData> allRoundData;

    private int num;

	void Start ()
    {
        
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("MainScene");
	}
	
    public RoundData GetCurrentRoundData()
    {

        return allRoundData[num];
    }

	void Update ()
    {
        num = Random.Range(0, 4);

    }
}
