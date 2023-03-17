using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 70;
    private float horizontal;
    public float speed;
    public GameObject playertwo;
    public GameObject[] bars;
    public GameObject Dia;
    public GameObject panel;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FullBar());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

        //horizontal = Input.GetAxis("Horizontal");
        //horizontal *= speed * Time.deltaTime;

        //transform.Translate(new Vector3(horizontal, 0f, 0f));
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5f, 5f), transform.position.y, transform.position.z);

        Bar();
        if (health < 70)
        {
            bars[0].SetActive(false);
        }
        if (health == 70) 
        {
            bars[0].SetActive(true);
        }
        if (health == 0)
        {
            panel.SetActive(true);
            bars[6].SetActive(false);
            bars[7].SetActive(true);
            playertwo.SetActive(false);
            Time.timeScale = 0f;
            if (CompareTag("Players"))
            {              
                Destroy(gameObject);
                

            }
        }
    }

    LoadingScene loadingscenes;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Objects"))
        {

            health -= 10;         
            if (health == 0)
            {
                panel.SetActive(true);
                bars[6].SetActive(false);
                bars[7].SetActive(true);
                playertwo.SetActive(false);
                Time.timeScale = 0f;
                Destroy(gameObject);
            }
        }

        if (col.gameObject.CompareTag("Dia"))
        {       
            health += 10;
            Destroy(Dia);
        }      
        if (col.gameObject.CompareTag("code"))
        {
            bars[8].SetActive(true);
        }
        if (col.gameObject.CompareTag("codetwo"))
        {
            bars[9].SetActive(true);
        }
        if (col.gameObject.CompareTag("codeth"))
        {
            bars[10].SetActive(true);
        }
        if (col.gameObject.CompareTag("codefh"))
        {
            bars[11].SetActive(true);
        }
        if (col.gameObject.CompareTag("codefv"))
        {
            bars[12].SetActive(true);
        }
        if (col.gameObject.CompareTag("codes"))
        {
            bars[8].SetActive(true);
            bars[9].SetActive(true);
        }
    }
    private void Bar()
    {
        if (health == 70) 
        {
            
        }
        else if (health == 60)
        {
            bars[0].SetActive(false);
            bars[1].SetActive(true);
        }
        else if (health == 50)
        {
            bars[1].SetActive(false);
            bars[2].SetActive(true);
        }
        else if (health == 40)
        {
            bars[2].SetActive(false);
            bars[3].SetActive(true);
        }
        else if (health == 30)
        {
            bars[3].SetActive(false);
            bars[4].SetActive(true);
        }
        else if (health == 20)
        {
            bars[4].SetActive(false);
            bars[5].SetActive(true);
        }
        else if (health == 10)
        {
            bars[5].SetActive(false);
            bars[6].SetActive(true);
        }
        else if (health == 0)
        {
            bars[7].SetActive(true);
            bars[6].SetActive(false);          
        }
    }

    IEnumerator FullBar()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            health -= 10;
        }
    }

}
