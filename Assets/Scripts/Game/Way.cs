using UnityEngine;

public class Way : MonoBehaviour
{
   [SerializeField] private Transform[] points;

   public Transform[] Points => points;
}
