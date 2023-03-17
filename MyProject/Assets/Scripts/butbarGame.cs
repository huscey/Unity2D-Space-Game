using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butbarGame : MonoBehaviour
{
    public int barHealth = 50;
    [SerializeField] GameObject[] butext;
    [SerializeField] GameObject[] bars;

    public void trueBut()
    {
        barHealth += 10;
        butext[0].SetActive(false);
        butext[1].SetActive(false);
        butext[2].SetActive(true);
        butext[3].SetActive(true);
        butext[4].SetActive(false);
        butext[5].SetActive(true);
    }

    public void falseBut()
    {
        barHealth -= 10;
        butext[0].SetActive(false);
        butext[1].SetActive(false);
        butext[2].SetActive(true);
        butext[3].SetActive(true);
        butext[4].SetActive(false);
        butext[5].SetActive(true);
    }

    public void trueButton()
    {
        barHealth -= 10;
        butext[2].SetActive(false);
        butext[3].SetActive(false);
        butext[6].SetActive(true);
        butext[7].SetActive(true);
        butext[5].SetActive(false);
        butext[19].SetActive(true);
    }
    public void falseButton()
    {
        barHealth += 10;
        butext[2].SetActive(false);
        butext[3].SetActive(false);
        butext[6].SetActive(true);
        butext[7].SetActive(true);
        butext[5].SetActive(false);
        butext[8].SetActive(true);
    }

    public void truButton()
    {
        barHealth -= 10;
        butext[6].SetActive(false);
        butext[7].SetActive(false);
        butext[9].SetActive(true);
        butext[10].SetActive(true);
        butext[8].SetActive(false);
        butext[19].SetActive(false);
        butext[20].SetActive(true);
    }

    public void trruButton()
    {
        if (barHealth < 50)
        {
            barHealth -= 20;
        }
        if (barHealth > 50)
        {
            barHealth += 20;
        }
        if (barHealth == 50)
        {
            barHealth -= 20;
        }      
        butext[6].SetActive(false);
        butext[7].SetActive(false);
        butext[9].SetActive(true);
        butext[10].SetActive(true);
        butext[8].SetActive(false);
        butext[19].SetActive(false);
        butext[20].SetActive(true);
    }

    public void falButton()
    {
        barHealth += 10;
        butext[6].SetActive(false);
        butext[7].SetActive(false);
        butext[9].SetActive(true);
        butext[10].SetActive(true);
        butext[8].SetActive(false);
        butext[19].SetActive(false);
        butext[11].SetActive(true);
    }

    public void faltwoButton()
    {
        if(barHealth < 50)
        {
            barHealth += 10;
        }
        if (barHealth > 50)
        {
            barHealth -= 10;
        }
        butext[6].SetActive(false);
        butext[7].SetActive(false);
        butext[9].SetActive(false);
        butext[10].SetActive(false);
        butext[8].SetActive(false);
        butext[19].SetActive(false);
        butext[11].SetActive(true);
        butext[23].SetActive(true);
    }


    public void truBut()
    {
        barHealth += 10;
        butext[9].SetActive(false);
        butext[10].SetActive(false);
        butext[12].SetActive(true);
        butext[13].SetActive(true);
        butext[11].SetActive(false);
        butext[20].SetActive(false);
        butext[14].SetActive(true);
    }
    public void falBut()
    {
        barHealth -= 10;
        butext[9].SetActive(false);
        butext[10].SetActive(false);
        butext[12].SetActive(true);
        butext[13].SetActive(true);
        butext[11].SetActive(false);
        butext[20].SetActive(false);
        butext[14].SetActive(true);
    }
    public void faalBut()
    {
        barHealth -= 10;
        butext[9].SetActive(false);
        butext[10].SetActive(false);
        butext[12].SetActive(true);
        butext[13].SetActive(true);
        butext[11].SetActive(false);
        butext[20].SetActive(false);
        butext[22].SetActive(true);
    }

    public void faaltwoBut()
    {
        butext[9].SetActive(false);
        butext[10].SetActive(false);
        butext[12].SetActive(true);
        butext[13].SetActive(true);
        butext[11].SetActive(false);
        butext[20].SetActive(false);
        butext[22].SetActive(true);
    }

    public void lastTrueBut()
    {
        barHealth -= 10;
        butext[12].SetActive(false);
        butext[13].SetActive(false);
        butext[15].SetActive(true);
        butext[16].SetActive(true);
        butext[14].SetActive(false);
        butext[21].SetActive(false);
        butext[22].SetActive(false);
    }

    public void lastFalseBut()
    {
        barHealth += 10;
        butext[12].SetActive(false);
        butext[13].SetActive(false);
        butext[15].SetActive(true);
        butext[16].SetActive(true);
        butext[14].SetActive(false);
        butext[21].SetActive(false);
        butext[22].SetActive(false);
    }

    public void AgainTry() 
    {
        SceneManager.LoadScene(0);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(4);
    }

    private void Update()
    {
        if (barHealth <= 10 || barHealth >= 90)
        {
            butext[17].SetActive(true);
            butext[18].SetActive(true);
            butext[0].SetActive(false);
            butext[1].SetActive(false);
            butext[2].SetActive(false);
            butext[3].SetActive(false);
            butext[4].SetActive(false);
            butext[5].SetActive(false);
            butext[6].SetActive(false);
            butext[7].SetActive(false);
            butext[8].SetActive(false);
            butext[9].SetActive(false);
            butext[10].SetActive(false);
            butext[11].SetActive(false);
            butext[12].SetActive(false);
            butext[13].SetActive(false);
            butext[14].SetActive(false);
            butext[15].SetActive(false);
            butext[16].SetActive(false);
            butext[19].SetActive(false);
            butext[20].SetActive(false);
            butext[22].SetActive(false);
            butext[23].SetActive(false);

        }
        if (barHealth == 50)
        {
            bars[0].SetActive(true);
            bars[1].SetActive(false);
            bars[2].SetActive(false);
            bars[3].SetActive(false);
            bars[4].SetActive(false);
            bars[5].SetActive(false);
            bars[6].SetActive(false);
            bars[7].SetActive(false);
            bars[8].SetActive(false);
        }
        else if (barHealth == 60)
        {
            bars[4].SetActive(true);
            bars[1].SetActive(false);
            bars[2].SetActive(false);
            bars[3].SetActive(false);
            bars[0].SetActive(false);
            bars[5].SetActive(false);
            bars[6].SetActive(false);
            bars[7].SetActive(false);
            bars[8].SetActive(false);
        }
        else if (barHealth == 70)
        {
            bars[3].SetActive(true);
            bars[1].SetActive(false);
            bars[2].SetActive(false);
            bars[0].SetActive(false);
            bars[4].SetActive(false);
            bars[5].SetActive(false);
            bars[6].SetActive(false);
            bars[7].SetActive(false);
            bars[8].SetActive(false);
        }
        else if (barHealth == 80)
        {
            bars[2].SetActive(true);
            bars[1].SetActive(false);
            bars[0].SetActive(false);
            bars[3].SetActive(false);
            bars[4].SetActive(false);
            bars[5].SetActive(false);
            bars[6].SetActive(false);
            bars[7].SetActive(false);
            bars[8].SetActive(false);
        }
        else if (barHealth == 90)
        {
            bars[1].SetActive(true);
            bars[0].SetActive(false);
            bars[2].SetActive(false);
            bars[3].SetActive(false);
            bars[4].SetActive(false);
            bars[5].SetActive(false);
            bars[6].SetActive(false);
            bars[7].SetActive(false);
            bars[8].SetActive(false);
        }
        else if (barHealth == 40)
        {
            bars[8].SetActive(true);
            bars[1].SetActive(false);
            bars[2].SetActive(false);
            bars[3].SetActive(false);
            bars[4].SetActive(false);
            bars[5].SetActive(false);
            bars[6].SetActive(false);
            bars[7].SetActive(false);
            bars[0].SetActive(false);
        }
        else if (barHealth == 30)
        {
            bars[7].SetActive(true);
            bars[1].SetActive(false);
            bars[2].SetActive(false);
            bars[3].SetActive(false);
            bars[4].SetActive(false);
            bars[5].SetActive(false);
            bars[6].SetActive(false);
            bars[0].SetActive(false);
            bars[8].SetActive(false);
        }
        else if (barHealth == 20)
        {
            bars[6].SetActive(true);
            bars[1].SetActive(false);
            bars[2].SetActive(false);
            bars[3].SetActive(false);
            bars[4].SetActive(false);
            bars[5].SetActive(false);
            bars[0].SetActive(false);
            bars[7].SetActive(false);
            bars[8].SetActive(false);
        }
        else if (barHealth == 10)
        {
            bars[5].SetActive(true);
            bars[1].SetActive(false);
            bars[2].SetActive(false);
            bars[3].SetActive(false);
            bars[4].SetActive(false);
            bars[0].SetActive(false);
            bars[6].SetActive(false);
            bars[7].SetActive(false);
            bars[8].SetActive(false);
        }
    }

    public void aChoButton()
    {
        barHealth += 10;
        butext[0].SetActive(false);
        butext[1].SetActive(false);
        butext[2].SetActive(true);
        butext[3].SetActive(true);
        butext[4].SetActive(false);
        butext[5].SetActive(true);
    }

    public void bChoButton()
    {
        barHealth -= 10;
        butext[2].SetActive(false);
        butext[3].SetActive(false);
        butext[6].SetActive(true);
        butext[7].SetActive(true);
        butext[5].SetActive(false);
        butext[19].SetActive(true);
    }

    public void bChoTwoButton()
    {
        barHealth -= 10;
        butext[2].SetActive(false);
        butext[3].SetActive(false);
        butext[6].SetActive(true);
        butext[7].SetActive(true);
        butext[5].SetActive(false);
        butext[8].SetActive(true);
    }

    public void cChoButton()
    {
        barHealth -= 10;
        butext[6].SetActive(false);
        butext[7].SetActive(false);
        butext[9].SetActive(true);
        butext[10].SetActive(true);
        butext[8].SetActive(false);
        butext[19].SetActive(false);
        butext[20].SetActive(true);
    }

    public void cChoTwoButton()
    {
        barHealth -= 10;
        butext[6].SetActive(false);
        butext[7].SetActive(false);
        butext[9].SetActive(true);
        butext[10].SetActive(true);
        butext[8].SetActive(false);
        butext[19].SetActive(false);
        butext[11].SetActive(true);
    }

    public void dChoButton()
    {
        barHealth += 10;
        butext[9].SetActive(false);
        butext[10].SetActive(false);
        butext[12].SetActive(true);
        butext[13].SetActive(true);
        butext[11].SetActive(false);
        butext[20].SetActive(false);
        butext[14].SetActive(true);
    }

    public void eChoButton()
    {
        barHealth -= 10;
        butext[12].SetActive(false);
        butext[13].SetActive(false);
        butext[15].SetActive(true);
        butext[16].SetActive(true);
        butext[14].SetActive(false);
        butext[21].SetActive(false);
    }


}
