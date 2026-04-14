using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allcherries : MonoBehaviour
{
    public class GameManager
    {
        // 单例模式
        private static GameManager _instance;
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameManager();
                return _instance;
            }
        }

        // 计分板数据
        public int score = 0;
        public int dead = 0;
    }
}