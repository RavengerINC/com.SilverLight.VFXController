using System.Collections.Generic;
using UnityEngine;

namespace VisualEffects.Controller
{
    public class VisualEffectSequence : MonoBehaviour
    {
        public string Name;

        [Range(0, 1)] public float Percent;

        [SerializeReference] public List<BaseController> controllers;

        private void OnEnable()
        {
            foreach (var controller in controllers)
            {
                controller.SetOnEnable();
            }
        }

        private void OnDisable()
        {
            Percent = 0;

            foreach (var controller in controllers)
            {
                controller.SetOnDisable();
            }
        }

        private void Update()
        {
            foreach (var controller in controllers)
            {
                controller.SetUpdate(Percent);
            }
        }
    }
}
