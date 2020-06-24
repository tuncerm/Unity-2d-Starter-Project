using UnityEditor;
using UnityEngine;

namespace KoltukStudio
{
    public class GameQuitter : MonoBehaviour
    {
        public void QuitGame()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}