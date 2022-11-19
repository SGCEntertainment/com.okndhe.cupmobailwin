using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI ballN;

    public int ball = 3;
    public int scoreC;

    private bool inPres = false;
    private bool isDel = false;
    public GameObject star;
    public GameObject ballObj;

    public void Click()
    {
        ball--;
        Instantiate(ballObj, new Vector3(0, -2.8f, 0), Quaternion.identity);

        if (inPres)
        {
            scoreC += 5;

            Instantiate(star, transform.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        score.text = scoreC.ToString();
        ballN.text = ball.ToString();

        if (ball <= 0) StartCoroutine(Del());

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            inPres = true;
            if (isDel)
            {
                isDel = false;
                Destroy(collision.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inPres = false;
    }

    private IEnumerator Del()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
