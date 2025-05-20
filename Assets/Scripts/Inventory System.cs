using UnityEngine;
using System.Collections.Generic;
using System;

namespace Inventory
{


    public class InventorySystem : MonoBehaviour
    {

        #region Propperties

        #endregion

        #region Fields
        [Header("UI Reffs")]
        [SerializeField] private ItemButton[] _prefabButton;
        [SerializeField] private Transform _inventory;

        [Header("Object Definition")]
        [SerializeField] private Weapon[] _weapons;
        [SerializeField] private Food[] _food;
        [SerializeField] private Other[] _other;
        [Header("Item Pool")]
        [SerializeField] private List<Item> _items = new List<Item>();

        #endregion

        #region Unity Callbacks
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            InitializeItems();
            InitializeUI();

        }





        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        private void InitializeUI()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                ItemButton newButton = Instantiate(_prefabButton, _prefabButton.transform.parent);
                newButton.CurrentItem = _items[i];
                newButton.OnClick += AddItem(newButton);
            }



        }

        public Action AddItem(ItemButton newButton)
        {
            throw new NotImplementedException();
        }

        private void InitializeItems()
        {


            //Weapons
            for (int i = 0; i < _weapons.Length; i++)
                _items.Add(_weapons[i]);

            //Food
            for (int i = 0; i < _food.Length; i++)
                _items.Add(_food[i]);

        }

        private ItemButton Instantiate(ItemButton[] prefabButton, object parent)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}