using UnityEngine;
using System.Collections;

public class PlayerStats
{

    private int lvl;
    public int Level
    {
        get
        {
            return lvl;
        }
    }
    private int maxlvl;
    public int Maxlvl
    {
        get
        {
            return maxlvl;
        }
    }
    private int exp;
    public int Experience
    {
        get
        {
            return exp;
        }
    }
    private int maxExp;
    public int MaxExperience
    {
        get
        {
            return maxExp;
        }
    }
    private int hp;
    public int Health
    {
        get
        {
            return hp;
        }
    }

    private int maxHp;
    public int MaxHealth
    {
        get
        {
            return maxHp;
        }
    }

    private int mana;
    public int Mana
    {
        get
        {
            return mana;
        }
    }

    private int maxMana;
    public int MaxMana
    {
        get
        {
            return maxMana;
        }
    }

    private int def;
    public int Defense
    {
        get
        {
            return def;
        }
    }

    private int attk;
    public int Attack
    {
        get
        {
            return attk;
        }
    }

    private int attkRange;
    public int AttackRange
    {
        get
        {
            return attkRange;
        }
    }

    private int movSpd;
    public int MovementSpeed
    {
        get
        {
            return movSpd;
        }
    }
		
    public PlayerStats(int _maxHp, int _maxMana, int _attk, int _def, int _attkRange, int _movSpd)
    {
        lvl = 1;
        maxExp = 50;
        exp = 0;
        maxHp = _maxHp;
        hp = _maxHp;
        maxMana = _maxMana;
        mana = _maxMana;

        attk = _attk;
        def = _def;

        attkRange = _attkRange;
        movSpd = _movSpd;

    }

    //Experience

    public void GainExperience(int _exp)
	{
		if (lvl != Maxlvl) {
			exp += _exp;
			if (exp >= maxExp) {
				exp -= maxExp;
				lvl += 1;
				maxExp = Mathf.FloorToInt (.1f * Mathf.Pow (lvl, 2f) + 50f);
			}
		} else {
			exp = maxExp;
		}
	}

    //Health

    public void GainHealth(int _heal)
    {
        if (hp + _heal > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp += _heal;
        }
		GameObject.Find ("HealthBar").GetComponent<RectTransform> ().localScale = new Vector3 ((hp*1.0f)*6 / maxHp, 6, 1);
    }

    public void LoseHealth(int _hurt)
    {
        if (hp - _hurt <= 0)
        {
            hp = 0;
        }
        else
        {
            hp -= _hurt;
        }
		GameObject.Find ("HealthBar").GetComponent<RectTransform> ().localScale = new Vector3 ((hp*1.0f)*6 / maxHp, 6, 1);
    }

    //Max Health

    public void GainMaxHealth(int _maxHpGain)
    {
        float prop = hp / (maxHp * 1.0f);
        maxHp += _maxHpGain;
        hp = (int)(maxHp * prop);
		GameObject.Find ("HealthBar").GetComponent<RectTransform> ().localScale = new Vector3 ((hp*1.0f)*6 / maxHp, 6, 1);
    }

    //Mana
    public void GainMana(int _mana)
    {
        if (mana + _mana > maxMana)
        {
            mana = maxMana;
        }
        else
        {
            mana += _mana;
        }
		GameObject.Find ("ManaBar").GetComponent<RectTransform> ().localScale = new Vector3 ((mana*1.0f)*6 / maxMana, 6, 1);
    }

    public void LoseMana(int _mana)
    {
        if (mana - _mana <= 0)
        {
            mana = 0;
        }
        else
        {
            mana -= _mana;
        }
		GameObject.Find ("ManaBar").GetComponent<RectTransform> ().localScale = new Vector3 ((mana*1.0f)*6 / maxMana, 6, 1);
    }

    //Max Mana

    public void GainMaxMana(int _maxManaGain)
    {
        float prop = mana / (maxMana * 1.0f);
        maxMana += _maxManaGain;
        mana = (int)(maxMana * prop);
		GameObject.Find ("ManaBar").GetComponent<RectTransform> ().localScale = new Vector3 ((mana*1.0f)*6 / maxMana, 6, 1);
    }

    //Defence

    public void GainDefense(int _defGain)
    {
        def += _defGain;
    }

    public void LoseDefense(int _defLose)
    {
        def -= _defLose;
    }

    //Attack

    public void GainAttackDamage(int _attkGain)
    {
        attk += _attkGain;
    }

    public void LoseAttackDamage(int _attkLose)
    {
        attk -= _attkLose;
    }

    //Attack Range

    public void GainAttackRange(int _attkRangeGain)
    {
        attkRange += _attkRangeGain;
    }

    public void LostAttackRange(int _attkRangeLose)
    {
        attkRange -= _attkRangeLose;
    }


    //Move Speed

    public void GainMoveSpeed(int _movSpdGain)
    {
        movSpd += _movSpdGain;
    }

    public void LoseMoveSpeed(int _movSpdLose)
    {
        movSpd -= _movSpdLose;
    }

}