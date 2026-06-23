using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class EnableGameObjectController : BaseGameObjectController
    {
        protected override void Update(GameObject go, float percent, int loop)
        {
            // No-op
        }

        protected override void OnEnable(GameObject go, int loop)
        {
            go.SetActive(true);
        }

        protected override void OnDisable(GameObject go, int loop)
        {
            go.SetActive(false);
        }
    }
}
