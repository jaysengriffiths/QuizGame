using UnityEngine;
using System.Collections;

[System.Serializable]
public class QuestionData
{
    public string questionText;
    public AnswerData[] answers;
    public AudioClip clip = null;
    public Sprite image = null;

}
