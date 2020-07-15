using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AlarmSystem : MonoBehaviour
{
    [SerializeField] private UnityEvent _alarmActivated;
    [SerializeField] private UnityEvent _alarmDeactivated;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<ThiefPlayer>(out ThiefPlayer thiefPlayer))
        {
            _alarmActivated?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<ThiefPlayer>(out ThiefPlayer thiefPlayer))
        {
            _alarmDeactivated?.Invoke();
        }
    }


}