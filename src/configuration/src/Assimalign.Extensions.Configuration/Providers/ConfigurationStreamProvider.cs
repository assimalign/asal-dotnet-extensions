﻿using System;
using System.IO;


namespace Assimalign.Extensions.Configuration.Providers
{

    /// <summary>
    /// Stream based configuration provider
    /// </summary>
    public abstract class ConfigurationStreamProvider : ConfigurationProvider
    {
        /// <summary>
        /// The source settings for this provider.
        /// </summary>
        public ConfigurationStreamSource Source { get; }

        private bool _loaded;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="source">The source.</param>
        public ConfigurationStreamProvider(ConfigurationStreamSource source)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Load the configuration data from the stream.
        /// </summary>
        /// <param name="stream">The data stream.</param>
        public abstract void Load(Stream stream);

        /// <summary>
        /// Load the configuration data from the stream. Will throw after the first call.
        /// </summary>
        public override void Load()
        {
            if (_loaded)
            {
                throw new InvalidOperationException(); //SR.StreamConfigurationProvidersAlreadyLoaded);
            }
            Load(Source.Stream);
            _loaded = true;
        }
    }
}