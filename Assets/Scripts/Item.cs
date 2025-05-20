using UnityEngine;
using System;
using UnityEngine.UI;

namespace Inventory
{


    [Serializable]
    public class Item
    {

        #region Propperties
        [field: SerializeField] public string Name { get; set; }

        public static implicit operator Button(Item v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Item(Button v)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
