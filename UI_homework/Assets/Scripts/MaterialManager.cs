using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    [SerializeField] private Renderer[] _renderers;

    public void SetMaterial(Material material) {
        for (int i = 0; i < _renderers.Length; i++)
        {
            _renderers[i].material = material;
        }
        //_renderer.material = material;
    }

}
