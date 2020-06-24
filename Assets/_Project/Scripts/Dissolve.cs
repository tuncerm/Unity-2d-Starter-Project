using UnityEngine;

namespace KoltukStudio
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Dissolve : MonoBehaviour
    {
        private Material _material;
        private bool _isDissolving;
        private float _fade = 1f;
        private static readonly int Fade = Shader.PropertyToID("_Fade");

        private void Start()
        {
            _material = GetComponent<SpriteRenderer>().material;
            _material.SetFloat(Fade, 1f);
        }

        private void OnMouseDown()
        {
            _isDissolving = true;
        }

        private void Update()
        {
            if (_isDissolving)
            {
                _fade -= Time.deltaTime;

                if (_fade <= 0f)
                {
                    _fade = 0f;
                    _isDissolving = false;
                }

                _material.SetFloat(Fade, _fade);
            }
            else if (_fade < 1f)
            {
                _fade += Time.deltaTime;

                if (_fade >= 1f)
                {
                    _fade = 1f;
                }

                _material.SetFloat(Fade, _fade);
            }
        }
    }
}