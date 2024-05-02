using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Game.UI
{
    public class LoadingMenu : Menu
    {
        protected AsyncOperation asyncOperation;
        [SerializeField] protected Image loadBar;

        public void StartLoadScene(int sceneID)
        {
            StartCoroutine(LoadScene(sceneID));
        }

        protected IEnumerator LoadScene(int sceneID)
        {
            yield return new WaitForSeconds(1);
            asyncOperation = SceneManager.LoadSceneAsync(sceneID);

            while (!asyncOperation.isDone)
            {
                loadBar.transform.Rotate(0, 0, 15);
                yield return null;
            }
        }
    }
}