using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
     [SerializeField] private ScoreCounter scoreWay;
     [SerializeField] private Way way;
     [SerializeField] private Transform player;
     [SerializeField] private Vector2Int borderValue;
     [SerializeField] private Text text;

     public UnityEvent zeroStepEvent;
     
     private int currentValue;
     
     private void MovePlayer()
     {
               player.position = way.Points[(int)scoreWay.Score - 1].position;
     }

     private void GenerateNewValue()
     {
          currentValue = Random.Range(borderValue.x,borderValue.y);
          text.text = $"{currentValue}";
          if(currentValue == 0)zeroStepEvent?.Invoke();
     }

     public void MakeStep()
     {
          GenerateNewValue();
          scoreWay.Add(currentValue);
          MovePlayer();
     }
}
