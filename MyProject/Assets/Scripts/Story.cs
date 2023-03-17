using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    public string yazi;

    private Text text;
    public GameObject goButton;
    private void Start()
    {
        text = GetComponent<Text>();

        StartCoroutine(Write());
        StartCoroutine(MoveGo());
    }
    public void goBut()
    {
        SceneManager.LoadScene(2);
    }
    IEnumerator Write()
    {
        foreach(char i in yazi)
        {
            text.text += i.ToString();
            if (i.ToString() == ".")
            {
                yield return new WaitForSeconds(1);
            }
            else 
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
    IEnumerator MoveGo()
    {
        yield return new WaitForSeconds(3f);
        goButton.SetActive(true);
    }

}
