using System.Collections;
using System.Collections.Generic;
using TankGame.Inventory;
using UnityEngine;


namespace TankGame.Stat
{
    [CreateAssetMenu(menuName = "Tank Game/Inventory/Scriptable Stat Manager")]
    public class ScriptableStatManager : AbstractScriptableManager<ScriptableStatManager>
    {
        private List<PlayerStat> _playerStatList = new List<PlayerStat>();
        public void RegisterStat(PlayerStat stat)
        {
            _playerStatList.Add(stat);
        }


        public PlayerStat Find(int id)
        {
            for (int i = 0; i < _playerStatList.Count; i++)
            {
                if (_playerStatList[i].Id == id)
                {
                    return _playerStatList[i];
                }
            }
            throw new System.Exception("Couldn't find player stat with id  : " + id);
        }
    }
}