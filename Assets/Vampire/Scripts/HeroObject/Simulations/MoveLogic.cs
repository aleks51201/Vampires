using System;
using UnityEngine;

namespace Vampire.HeroObject.Simulations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class MoveLogic
    {
        private Rigidbody2D _rb;
        private Transform _transform;
        private float _moveSpeed;


        public MoveLogic(Rigidbody2D rb, Transform transform, float moveSpeed)
        {
            _rb = rb;
            _transform = transform;
            _moveSpeed = moveSpeed;
        }

        public void Move(Single moveInput)
        {
            _rb.velocity = new Vector2(moveInput * _moveSpeed, _rb.velocity.y);
        }
    }
}
