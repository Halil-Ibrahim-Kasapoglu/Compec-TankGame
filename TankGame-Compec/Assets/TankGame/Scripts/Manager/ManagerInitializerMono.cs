using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class ManagerInitializerMono : MonoBehaviour
    {
        [SerializeField] private AbstractScriptableManagerBase[] _abstractScriptableManagerArray;
        private List<AbstractScriptableManagerBase> _instantiatedAbstractScriptableManagerList;

        private void Start()
        {
            _instantiatedAbstractScriptableManagerList = new List<AbstractScriptableManagerBase>(_abstractScriptableManagerArray.Length);

            foreach (var item in _abstractScriptableManagerArray)
            {
                var instantiated = Instantiate(item);
                instantiated.Initialize();
                _instantiatedAbstractScriptableManagerList.Add(instantiated);
            }

        }


        private void OnDestroy()
        {
            if (_instantiatedAbstractScriptableManagerList != null)
            {
                foreach (var item in _instantiatedAbstractScriptableManagerList)
                {
                    item.Destroy();
                }
            }
        }
    }
}