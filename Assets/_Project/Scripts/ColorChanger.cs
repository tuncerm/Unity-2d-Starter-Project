using UnityEngine;

namespace KoltukStudio
{
    [RequireComponent(typeof(Collider2D))]
    public class ColorChanger : MonoBehaviour
    {
        private SpriteRenderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }

        public void OnMouseDown()
        {
            Debug.Log(name + " is clicked!");
            var r = Random.Range(0f, 1f);
            var g = Random.Range(0f, 1f);
            var b = Random.Range(0f, 1f);
            Debug.Log($"New color values are r: {r}, g: {g}, b: {b}");
            _renderer.color = new Color(r,g,b);
        }
    }
}