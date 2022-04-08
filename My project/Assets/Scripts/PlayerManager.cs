using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Self Variables
    #region Serialized Variables

    [SerializeField] private PlayerMovementController movementController;
    [SerializeField] provate Rigidbody rigidbody;

    #region Private Variables
        private bool _isReadyToMove;
    #endregion


    // Update is called once per frame
    void Update()
    {
        
    }
}
