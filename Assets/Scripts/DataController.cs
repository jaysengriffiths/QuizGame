using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public RoundData[] allRoundData;


	void Start ()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("MainScene");
	}
	
    public RoundData GetCurrentRoundData()
    {
        return allRoundData[0];
    }

	void Update ()
    {
	
	}
}
