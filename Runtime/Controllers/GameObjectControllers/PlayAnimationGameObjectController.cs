using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class PlayAnimationGameObjectController : BaseGameObjectController
    {
        public string[] AnimationName;
        
        private Animator[] m_Animator;
        
        protected override void Update(GameObject go, float percent, int loop)
        {
            m_Animator[loop].Play(AnimationName[loop], 0, percent);
            m_Animator[loop].Update(0);
        }

        protected override void OnEnable(GameObject go, int loop)
        {
            go.SetActive(true);
            
            if(m_Animator == null)
                m_Animator = new Animator[m_GameObject.Length];
            
            m_Animator[loop] = go.GetComponent<Animator>();
            m_Animator[loop].speed = 0;
            m_Animator[loop].Play(AnimationName[loop], 0, 0);
            m_Animator[loop].Update(0);
        }

        protected override void OnDisable(GameObject go, int loop)
        {
            go.SetActive(false);
        }
    }
}
