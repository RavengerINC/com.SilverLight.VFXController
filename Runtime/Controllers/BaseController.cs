using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public abstract class BaseController
    {
        public abstract void SetUpdate(float percent);
        public abstract void SetOnEnable();
        public abstract void SetOnDisable();
    }
}
