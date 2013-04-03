﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System;
using Microsoft.AspNet.SignalR.Messaging;

namespace Microsoft.AspNet.SignalR
{
    /// <summary>
    /// Settings for the SQL Server scale-out message bus implementation.
    /// </summary>
    public class SqlScaleoutConfiguration : ScaleoutConfiguration
    {
        public SqlScaleoutConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
            TableCount = 1;
        }

        /// <summary>
        /// The connection string to use.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// The number of tables to store messages in. Using more tables reduces lock contention and can increase throughput.
        /// Defaults to 1.
        /// </summary>
        public int TableCount { get; set; }
    }
}
