using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Providers
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class FeatureToggleProviderBase
    {
        /// <summary>
        /// 
        /// </summary>
        protected FeatureToggleProviderBase()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="toggleName"></param>
        /// <returns></returns>
        public abstract T GetToggleValueAs<T>(string toggleName);
    }
}
