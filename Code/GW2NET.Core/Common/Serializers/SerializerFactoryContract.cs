﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializerFactoryContract.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the SerializerFactoryContract type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.Common.Serializers
{
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(ISerializerFactory))]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Only used by the Code Contracts for .NET extension.")]
    internal abstract class SerializerFactoryContract : ISerializerFactory
    {
        public ISerializer<T> GetSerializer<T>()
        {
            Contract.Ensures(Contract.Result<ISerializer<T>>() != null);
            throw new System.NotImplementedException();
        }
    }
}