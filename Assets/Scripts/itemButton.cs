using Inventory;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class ItemButton : MonoBehaviour
    {

        #region Propperties
        public Button CurrentItem
        {
            get
            {

                return _currentItem;

            }
            set
            {
                _currentItem = value;
                _buttonText.text = _currentItem.Name;
            }
        }



        public event Action OnClick;

        #endregion

        #region Fields
        private TextMeshProUGUI _buttonText;
        private Button _button;
        private Item _currentItem;
        #endregion

        #region Unity Callbacks
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _button = GetComponent<Button>();
            _buttonText = GetComponentInChildren<TextMeshProUGUI>();
            //Delegate example
            _button.onClick.AddListener(() => OnClick?.Invoke());
        }

        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}