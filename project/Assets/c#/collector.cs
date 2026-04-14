using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static allcherries;

public class collector : MonoBehaviour
{
    int cherries = GameManager.Instance.score;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource getSoundEffect;

    private void Start()
    {
        // 初始化时更新UI显示
        if (cherriesText != null)
        {
            cherriesText.text = $"Cherries: {cherries}";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            getSoundEffect.Play();
            cherriesText.text = "Cherries:" + cherries;
            GameManager.Instance.score = cherries;
        }
    }
}