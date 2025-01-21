using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public struct QuestionsAndAnswers
{
    public string question;
    public string[] answers;
}

public class Question_Manager : MonoBehaviour
{
    public QuestionsAndAnswers [] questionsAndAnswers;
    public Npc npc;

    public Text answerText;

    public List<bool> answers = new();
    public List<Image> buttonImages;
    public List<TMP_Text> buttonText;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Image>().color = Color.green;
        //ColorBlock colors = GetComponent<Button>().colors;
        //colors.normalColor = Color.red;
        //GetComponent<Button>().colors = colors;
        StartQuiz();
    }

    void Swap(int i1, int i2)
    {
        QuestionsAndAnswers temp = questionsAndAnswers[i1];
        questionsAndAnswers[i1] = questionsAndAnswers[i2];
        questionsAndAnswers[i2] = temp;
    }

    void Swap(int[] answers, int i1, int i2)
    {
        int temp = answers[i1];
        answers[i1] = answers[i2];
        answers[i2] = temp;
    }

    public void StartQuiz()
    {
        for (int i = 0; i < questionsAndAnswers.Length; ++i)
        {
            Swap(i,Random.Range(i, questionsAndAnswers.Length));
        }

        for (int i = 0; i < questionsAndAnswers.Length; ++i)
        {
            npc.AddQuestion(questionsAndAnswers[i].question);
        }
    }

    void SetAnswers(QuestionsAndAnswers questionAndAnswer)
    {
        int[] answerIndex = new int[4] { 0, 1, 2, 3 };

        for (int i = 0; i < 4; ++i)
        {
            Swap(answerIndex, i, Random.Range(i, 4));
        }

        for (int i = 0; i < buttonText.Count; ++i)
        {
            buttonText[i].text = questionAndAnswer.answers[answerIndex[i]];
            answers[i] = answerIndex[i] == 0;
            buttonImages[i].color = Color.white;
        }
    }

    public void SetAnswers(string question)
    {
        foreach (var qanda in questionsAndAnswers)
        {
            if (qanda.question == question)
            {
                SetAnswers(qanda);
                break;
            }
        }
    }

    public void OptionOne()
    {
        if (answers[0])
        {
            print("Correct");
            buttonImages[0].color = Color.green;
        }
        else buttonImages[0].color = Color.red;
    }

    public void OptionTwo()
    {
        if (answers[1])
        {
            print("Correct");
            buttonImages[1].color = Color.green;
        }
        else buttonImages[1].color = Color.red;
    }

    public void OptionThree()
    {
        if (answers[2])
        {
            print("Correct");
            buttonImages[2].color = Color.green;
        }
        else buttonImages[2].color = Color.red;
    }

    public void OptionFour()
    {
        if (answers[3])
        {
            print("Correct");
            buttonImages[3].color = Color.green;
        }
        else buttonImages[3].color = Color.red;
    }
   
}
