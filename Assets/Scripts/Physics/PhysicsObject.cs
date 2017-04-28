using UnityEngine;

namespace Physics
{
    public class PhysicsObject : MonoBehaviour
    {
        public float GravityModifier = 1f;

        // Movement
        protected Rigidbody2D Rb;
        protected Vector2 Velocity;
        protected Vector2 TargetVelocity;

        // Collisions
        protected Vector2 GroundNormal;

        private void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
        }


        private void Update()
        {
            TargetVelocity = Vector2.zero;
            ComputeVelocity();
        }

        protected virtual void ComputeVelocity()
        {
        }

        private void FixedUpdate()
        {
            Velocity += GravityModifier * Physics2D.gravity * Time.deltaTime;
            Velocity.x = TargetVelocity.x;

            var deltaPosition = Velocity * Time.deltaTime;

            Rb.MovePosition(Rb.position + deltaPosition);
        }
    }
}