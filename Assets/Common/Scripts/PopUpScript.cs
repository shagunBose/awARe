using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpScript : MonoBehaviour
{
    public GameObject[] questionGroupArr;
    public QAClass[] QA;
    public GameObject answerPanel;
    public GameObject popup;



    // Start is called before the first frame update
    void Start()
    {
        QA = new QAClass[questionGroupArr.Length];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubmitAnswer()
    {
        for (int i = 0; i < QA.Length; i++)
        {
            QA[i] = ReadQuestionAndAnswer(questionGroupArr[i]);
        }
        popup.gameObject.SetActive(false);
        //displayResult();
    }

    QAClass ReadQuestionAndAnswer(GameObject QuestionGroup)
    {
        QAClass result = new QAClass();
        GameObject Q = QuestionGroup.transform.Find("Question").gameObject;
        GameObject A = QuestionGroup.transform.Find("Answer").gameObject;

        result.question = Q.GetComponent<Text>().text;
        result.answer = A.transform.Find("Text").GetComponent<Text>().text;

        return result;
    }

    void displayResult()
    {
       
        answerPanel.SetActive(true);

        string s = "Thanks for submitting a response! Let's all try to make a difference \n\nYou said: ";

        for (int i = 0; i < QA.Length; i++){
            s += QA[i].answer + "\n";
        }

        answerPanel.transform.Find("Answer").GetComponent<Text>().text = s;
    }

}




[System.Serializable]
public class QAClass 
{
    public string question;
    public string answer;
}
