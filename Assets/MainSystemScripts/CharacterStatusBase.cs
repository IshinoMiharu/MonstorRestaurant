using Unity.Collections;
using UnityEngine;

public abstract class CharacterStatusBase : MonoBehaviour
{
    [Tooltip("�ő�̗�")]
    public float _maxHealth = 100;
    
    [ReadOnly]
    public float _currentHealth = 0;

    [Tooltip("�ړ����x")]
    public float _moveSpeed = 5;

    [Tooltip("�U����")]
    public float _attack = 10;

    [Tooltip("�U�����x")]
    public float _attackSpeed = 1;

    private void Start()
    {
        if (TryGetComponent<CharacterActionBase>(out CharacterActionBase actionBase))
        {
            actionBase._moveSpeed = _moveSpeed;
        }
        else
        {
            Debug.LogError("�A�N�V�����n�R���|�[�l���g���A�^�b�`����Ă��܂���");
        }
        Initialize();
    }

    public virtual void Initialize() { }

    public void HitDamage(float damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
