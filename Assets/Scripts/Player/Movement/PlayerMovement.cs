using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //�������� ������������, ������ ������������
    [SerializeField] private float _playerSpeed;
    [SerializeField] private Button _button;

    //Rb ������, ��������� ������� �� ������ �������, ������ ��������
    private Rigidbody2D _playerRigidbody2d;
    private MovementAnimation _movementAnimation;
    private Vector2 _moveDirection;

    //����������� �������� �� ���� x, y
    public float DirectionX { get; set; }
    public float DirectionY { get; set; }

    private void Start()
    {
        _playerRigidbody2d = GetComponent<Rigidbody2D>();
        _movementAnimation = GetComponent<MovementAnimation>();
    }

    private void Update()
    {
        Move();
    }

    //��������� ��������� ������ ����� RigidBody.velocity
    private void Move()
    {
        _moveDirection = new Vector2(DirectionX, DirectionY);

        _playerRigidbody2d.velocity = _moveDirection * _playerSpeed * Time.deltaTime * 50;

        _movementAnimation.MoveAnimation(_playerRigidbody2d);
    }
    
}
