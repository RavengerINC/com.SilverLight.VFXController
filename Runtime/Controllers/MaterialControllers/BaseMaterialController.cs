using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public abstract class BaseMaterialController : BaseController
    {
        protected abstract void Update(Material material, float percent);
        protected abstract void OnEnable(Material material);
        protected abstract void OnDisable(Material material);

        public Renderer[] targets;
        private Material[] m_Targets;

        public override void SetUpdate(float percent)
        {
            if (targets.Length < 1) return;

            foreach (var material in m_Targets)
            {
                Update(material, percent);
            }
        }

        public override void SetOnEnable()
        {
            CacheMaterials();

            if (targets.Length < 1) return;

            foreach (var material in m_Targets)
            {
                OnEnable(material);
            }
        }

        public override void SetOnDisable()
        {
            if (targets.Length < 1) return;

            foreach (var material in m_Targets)
            {
                OnDisable(material);
            }
        }

        private void CacheMaterials()
        {
            m_Targets = new Material[targets.Length];

            for (int i = 0; i < targets.Length; i++)
            {
                m_Targets[i] = targets[i].material;
            }
        }
    }
}