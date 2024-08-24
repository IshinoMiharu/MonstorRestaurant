using Unity.Collections;
using UnityEngine;

public abstract class CharacterStatusBase : MonoBehaviour
{
    [Tooltip("最大体力")]
    public float _maxHealth = 100;
    
    [ReadOnly]
    public float _currentHealth = 0;

    [Tooltip("移動速度")]
    public float _moveSpeed = 5;

    [Tooltip("攻撃力")]
    public float _attack = 10;

    [Tooltip("攻撃速度")]
    public float _attackSpeed = 1;

    private void Start()
    {
        if (TryGetComponent<CharacterActionBase>(out CharacterActionBase actionBase))
        {
            actionBase._moveSpeed = _moveSpeed;
        }
        else
        {
            Debug.LogError("アクション系コンポーネントがアタッチされていません");
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
