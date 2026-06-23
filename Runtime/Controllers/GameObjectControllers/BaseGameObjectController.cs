using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public abstract class BaseGameObjectController : BaseController
    {
        protected abstract void Update(GameObject go, float percent, int loop);
        protected abstract void OnEnable(GameObject go, int loop);
        protected abstract void OnDisable(GameObject go, int loop);
        
        public GameObject[] m_GameObject;
        
        public override void SetUpdate(float percent)
        {
            for (int i = 0; i < m_GameObject.Length; i++)
            {
                Update(m_GameObject[i], percent, i);
            }
        }

        public override void SetOnEnable()
        {
            for (int i = 0; i < m_GameObject.Length; i++)
            {
                OnEnable(m_GameObject[i], i);
            }
        }

        public override void SetOnDisable()
        {
            for (int i = 0; i < m_GameObject.Length; i++)
            {
                OnDisable(m_GameObject[i], i);
            }
        }
    }
}
