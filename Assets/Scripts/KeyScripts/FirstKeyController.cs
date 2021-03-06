using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstKeyController : MonoBehaviour
{
    private Text keyText;

    // Start is called before the first frame update
    void Start()
    {
        keyText = GameObject.Find("KeyText").GetComponent<Text>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            collision.gameObject.GetComponent<PlayerMovement>().hasFirstKey = true;
            Destroy(this.gameObject);
            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        keyText.GetComponent<KeyScoreManager>().score += 1;
        keyText.GetComponent<KeyScoreManager>().UpdateScore();
    }
}
