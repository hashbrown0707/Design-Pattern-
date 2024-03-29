﻿using UnityEngine;

namespace Singleton.Script
{
    class GernericSingleton<T> where T : MonoBehavior
    {
        private static GernericSingleton<T> _instance;
        private static object _lock = new object();

        public static GernericSingleton<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = (T)FindObjectOfType(typeof(T));

                            if (FindObjectsOfType(typeof(T)).Length > 1)
                            {
                                Debug.LogError("[Singleton] Something went really wrong " +
                                               " - there should never be more than 1 singleton!" +
                                               " Reopenning the scene might fix it.");

                                return _instance;
                            }

                            if (_instance == null)
                            {
                                GameObject singleton = new GameObject();

                                _instance = singleton.AddComponent<T>();
                                singleton.name = "[Singleton] " + typeof(T).ToString();

                                DontDestroyOnLoad(singleton);

                                //Debug.Log("[Singleton] An instance of " + typeof(T) +
                                //          " is needed in the scene, so '" + singleton +
                                //          "' was created with DontDestroyOnLoad.");
                            }
                            //else
                            //{
                            //    Debug.Log("[Singleton] Using instance already created: " +
                            //              _instance.gameObject.name);
                            //}
                        }
                    }

                    return _instance;
                }
            }
        }

    private static bool applicationIsQuitting = false;

        private void OnApplicationQuit()
        {
            applicationIsQuitting = true;
        }
    }
}
