using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public abstract class Menu : MonoBehaviour
    {
        [SerializeField] protected List<GameObject> contentToOpen;

        public virtual void OpenMenu()
        {
            foreach (GameObject contentInMenu in contentToOpen)
            {
                contentInMenu.SetActive(true);
            }
        }

        public virtual void CloseMenu()
        {
            foreach (GameObject contentInMenu in contentToOpen)
            {
                contentInMenu.SetActive(false);
            }
        }
    }
}
