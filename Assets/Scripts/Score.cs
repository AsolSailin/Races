using UnityEngine;

public class Score : MonoBehaviour
{
    private const int RewardPerCheck = 5;
    private const float RewardPeriodSec = 1;

    private int _score;

    private float _nextCheckTime;

    private void Update()
    {
        if (!IsTimeToCheck())
        {
            return;
        }

        SetNextCheckTime();

        _score += GetReward();

        Debug.Log($"Reward is now {_score} points!");
    }

    private int GetReward()
    {
        return RewardPerCheck;
    }

    private float CurrentTimeProvider()
    {
        return Time.time;
    }

    private bool IsTimeToCheck()
    {
        var currentTime = CurrentTimeProvider();

        return _nextCheckTime < currentTime;
    }

    private void SetNextCheckTime()
    {
        _nextCheckTime = CurrentTimeProvider() + RewardPeriodSec;
    }
}