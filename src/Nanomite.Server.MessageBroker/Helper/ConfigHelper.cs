﻿///-----------------------------------------------------------------
///   File:         ConfigHelper.cs
///   Author:   	Andre Laskawy           
///   Date:         02.10.2018 16:47:28
///-----------------------------------------------------------------

namespace Nanomite.Server.MessageBroker.Helper
{
    using Microsoft.Extensions.Configuration;
    using Nanomite.Core.Server.Base;
    using System;
    using System.IO;
    using System.Net;

    /// <summary>
    /// Defines the <see cref="ConfigHelper" />
    /// </summary>
    public class ConfigHelper : IConfig
    {
        /// <summary>
        /// Defines the configuration
        /// </summary>
        private static IConfigurationRoot configuration = null;

        /// <summary>
        /// Gets or sets the LocalCloudAddress
        /// Gets the local cloud address.
        /// </summary>
        public string LocalCloudAddress
        {
            get
            {
                return Convert.ToString(Configuration["LocalCloudAddress"]);
            }
            set
            {
                Configuration["LocalCloudAddress"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the authentication server address.
        /// </summary>
        public string AuthServerAddress
        {
            get
            {
                return Convert.ToString(Configuration["AuthServerAddress"]);
            }
            set
            {
                Configuration["AuthServerAddress"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the PortGrpc
        /// Gets the port GRPC.
        /// </summary>
        public int PortGrpc
        {
            get
            {
                return Convert.ToInt32(Configuration["PortGrpc"]);
            }
            set
            {
                Configuration["PortGrpc"] = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the PortApi
        /// Gets the port API.
        /// </summary>
        public int PortApi
        {
            get
            {
                return Convert.ToInt32(Configuration["PortApi"]);
            }
            set
            {
                Configuration["PortApi"] = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the SrcDeviceId
        /// Gets the source device identifier.
        /// </summary>
        public string SrcDeviceId
        {
            get
            {
                var id = Convert.ToString(Configuration["SrcDeviceId"]);
                if (string.IsNullOrEmpty(id))
                {
                    return Dns.GetHostName();
                }
                else
                {
                    return id;
                }
            }
            set { }
        }

        /// <summary>
        /// Gets or sets the Secret
        /// </summary>
        public string Secret
        {
            get
            {
                return Configuration["Secret"];
            }
            set
            {
                Configuration["Secret"] = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the broker user password.
        /// </summary>
        public string BrokerPassword
        {
            get
            {
                return Configuration["BrokerPassword"];
            }
            set
            {
                Configuration["BrokerPassword"] = value.ToString();
            }
        }

        /// <summary>
        /// Gets the Configuration
        /// </summary>
        private IConfigurationRoot Configuration
        {
            get
            {
                if (configuration == null)
                {
                    configuration = GetConfig();
                }

                return configuration;
            }
        }

        /// <summary>
        /// The GetConfig
        /// </summary>
        /// <returns>The <see cref="IConfiguration"/></returns>
        private IConfigurationRoot GetConfig()
        {
            string assemblyPath = AppContext.BaseDirectory;

            if (!File.Exists(Path.Combine(assemblyPath, "appsettings.json")))
            {
                assemblyPath = AppContext.BaseDirectory;
            }

            var builder = new ConfigurationBuilder()
                   .SetBasePath(assemblyPath)
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .AddJsonFile($"appsettings.Dev.json", optional: true)
                   .AddEnvironmentVariables();
            return builder.Build();
        }
    }
}
