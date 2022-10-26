using System.Runtime.Caching;

namespace In_MemoryCaching.Services
{
    public class CacheService : ICacheService
    {
        ObjectCache _memoryCache = MemoryCache.Default;
        public T GetData<T>(string key)
        {
            try
            {
                T item = (T)_memoryCache.Get(key);
                return item;
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        public object RemoveData(string key)
        {
            try
            {
                if (!string.IsNullOrEmpty(key))
                {
                    _memoryCache.Remove(key);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }

        public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            bool res = true;
            try
            {
                if (!string.IsNullOrEmpty(key))
                {
                    _memoryCache.Set(key, value, expirationTime);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return res;
        }
    }
}
