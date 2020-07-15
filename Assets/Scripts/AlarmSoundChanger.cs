using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmSoundChanger : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _durationVolumeUp;
    [SerializeField] private float _durationVolumeDown;
    [SerializeField] private float _runningTime;

    private bool _alarmActivated;
    private bool _alarmDeactivated;

    public void VolumeUp() // вызывается в событии Alarm Sistem, в инспекторе
    {
        _runningTime = 0;
        _audioSource.Play();
        _alarmActivated = true;
        _alarmDeactivated = false;
    }

    public void VolumeDown() // вызывается в событии Alarm Sistem, в инспекторе
    {
        _runningTime = 0;
        _alarmActivated = false;
        _alarmDeactivated = true;
    }

    private void Update()
    {
        if (_alarmActivated)
        {
            _runningTime += Time.deltaTime;
            _audioSource.volume = Mathf.Lerp(0f, 1f, _runningTime / _durationVolumeUp);
        }
        if (_alarmDeactivated)
        {
            _runningTime += Time.deltaTime;
            _audioSource.volume = Mathf.Lerp(_audioSource.volume, 0f, _runningTime / _durationVolumeDown);

            if (_audioSource.volume <= 0.01f)
            {
                _audioSource.Stop();
            }
        }
    }
}
