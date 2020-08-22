using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{
    public class CardDistributor : MonoBehaviour
    {
        public GameObject[] prefabCards = new GameObject[52];
        private GameObject[] _cards = new GameObject[52];

        public Transform canvas;

        private static Transform _parent = null;

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            _cards[0] = Instantiate(prefabCards[0], canvas);
            //_cards[0] = prefabCards[0];
            //prefabCards[0].transform.position = Vector3.zero;

            for (int i = 1; i < 5; i++)
            {                
                _cards[i] = Instantiate(prefabCards[i], _cards[i-1].transform);
                _cards[i].transform.localPosition = new Vector3(0, -40.0f, 0);
            }
        }
    }
}

//FindObjectOfType<Canvas>().transform