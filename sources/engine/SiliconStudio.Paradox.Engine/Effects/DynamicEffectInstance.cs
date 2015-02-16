// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System.Collections.Generic;
using System.Threading.Tasks;
using SiliconStudio.Core.Collections;
using SiliconStudio.Paradox.Graphics;

namespace SiliconStudio.Paradox.Effects
{
    /// <summary>
    /// A dynamic effect instance updated by <see cref="DynamicEffectCompiler"/>.
    /// </summary>
    public abstract class DynamicEffectInstance
    {
        internal EffectParameterUpdaterDefinition UpdaterDefinition;
        internal EffectParameterUpdater Updater;
        internal Task<Effect> CurrentlyCompilingEffect;
        internal ParameterCollection CurrentlyCompilingUsedParameters;

        protected DynamicEffectInstance()
        {
            Updater = new EffectParameterUpdater();
        }

        /// <summary>
        /// Gets the effect currently being compiled.
        /// </summary>
        /// <value>The effect.</value>
        public Effect Effect { get; internal set; }

        /// <summary>
        /// Fills the parameter collections used by this instance.
        /// </summary>
        /// <param name="parameterCollections">The parameter collections.</param>
        public abstract void FillParameterCollections(FastList<ParameterCollection> parameterCollections);
    }
}