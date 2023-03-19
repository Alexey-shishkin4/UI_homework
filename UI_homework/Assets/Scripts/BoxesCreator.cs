using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxesCreator : MonoBehaviour
{
    [SerializeField] private Gold _goldPrefab;
    [SerializeField] private int _numberofgold = 3;
    [SerializeField] private float _speed = 5;
    [SerializeField] private Resources _resources;
    private bool _canCreate = true;


    public void Create()
    {
        for (int i = 0; i < _numberofgold; i++)
        {
            if (_canCreate)
            {
                Gold newgold = Instantiate(_goldPrefab, transform.position, Quaternion.identity);

                Vector3 velocity = Vector3.up;
                float xAngle = Random.Range(-45f, 45f);
                float yAngle = Random.Range(0, 360);

                velocity = Quaternion.Euler(xAngle, 0, 0) * velocity;
                velocity = Quaternion.Euler(0f, yAngle, 0f) * velocity;

                newgold.Setup(velocity * _speed, _resources);
                _canCreate = false;
                StartCoroutine(Creator());

            }
        }

    }

    private IEnumerator Creator()
    {
        yield return new WaitForSeconds(0.1f);
        _canCreate = true;
    }
}
