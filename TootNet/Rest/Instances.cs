﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{
    public class Instances : ApiBase
    {
        internal Instances(Tokens e) : base(e) { }

        /// <summary>
        /// <para>Returns information about instance.</para>
        /// <para>Available parameters:</para>
        /// <para>- No parameters available in this method.</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the account object.</para>
        /// </returns>
        public Task<Instance> GetAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Instance>(MethodType.Get, "instance", Utils.ExpressionToDictionary(parameters));
        }

        /// <summary>
        /// <para>Returns information about instance.</para>
        /// <para>Available parameters:</para>
        /// <para>- No parameters available in this method.</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the account object.</para>
        /// </returns>
        public Task<Instance> GetAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Instance>(MethodType.Get, "instance", parameters);
        }
    }
}
