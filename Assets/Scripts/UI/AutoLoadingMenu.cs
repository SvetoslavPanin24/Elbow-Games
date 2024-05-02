using UnityEngine;

namespace Game.UI
{
    public class AutoLoadingMenu : LoadingMenu
    {
        [SerializeField] private int sceneID;

        private void Start()
        {
            StartLoadScene(sceneID);
        }
    }
}
