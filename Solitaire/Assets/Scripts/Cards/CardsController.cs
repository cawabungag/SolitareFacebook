using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Game.Cards
{
    public class CardsController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        private RectTransform _rectTransform = null;

        private Transform _originParent = null;
        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            _rectTransform = GetComponent<RectTransform>();
            _originParent = _rectTransform.parent;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            //Отсоединяем от родителя карту
            _rectTransform.parent = FindObjectOfType<Canvas>().transform;
        }

        public void OnDrag(PointerEventData eventData)
        {
            //Следование карты за мышью
            _rectTransform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {

        }
    }
}
