using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static allcherries;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    int cherries = GameManager.Instance.score;

    [SerializeField] private Text cherriesText;

    int death = GameManager.Instance.dead;

    [SerializeField] private Text deathText;

    private void Start()
    {
        if (cherriesText != null)
        {
            cherriesText.text = $"get cherries: {cherries}";
        }

        if (deathText != null)
        {
            deathText.text = $"death: {death}";
        }
    }

    public void ReloadGame()
    {
        GameManager.Instance.score = 0;
        GameManager.Instance.dead = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
