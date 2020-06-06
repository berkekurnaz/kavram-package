using System;
using System.Collections.Generic;
using System.Text;

namespace Kavram.App
{
    public class KavramObject
    {

        private static KavramObject _kavram;
        private static object _lock = new object();

        public Dictionary<String, object> _dataList = new Dictionary<string, object>();

        protected KavramObject()
        {

        }

        /// <summary>
        /// This function create new storage
        /// </summary>
        /// <returns></returns>
        public static KavramObject Create()
        {
            lock (_lock)
            {
                if (_kavram == null)
                {
                    _kavram = new KavramObject();
                }
            }
            return _kavram;
        }

        /// <summary>
        /// This function get a variable from storage
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(String key)
        {
            try
            {
                if (_dataList.ContainsKey(key))
                {
                    return _dataList[key];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// This function add or update data by key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public bool Update(String key, object data)
        {
            try
            {
                if (_dataList.ContainsKey(key) == false)
                {
                    _dataList.Add(key, data);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This function delete object from storage by key
        /// </summary>
        /// <param name="key"></param>
        public bool Delete(String key)
        {
            try
            {
                if (_dataList.ContainsKey(key))
                {
                    _dataList.Remove(key);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This function remove all data to storage
        /// </summary>
        /// <returns></returns>
        public bool ClearAllData()
        {
            try
            {
                _dataList.Clear();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This function return all keys as string list
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllKeys()
        {
            List<string> result = new List<string>();
            foreach (var item in _dataList)
            {
                result.Add(item.Key);
            }
            return result;
        }

        /// <summary>
        /// This function return a storage's data count as integer
        /// </summary>
        /// <returns></returns>
        public int GetKeysCount()
        {
            return _dataList.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsKeyContains(String key)
        {
            try
            {
                if (_dataList.ContainsKey(key))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
