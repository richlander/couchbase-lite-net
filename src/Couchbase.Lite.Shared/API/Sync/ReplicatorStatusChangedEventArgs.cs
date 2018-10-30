﻿// 
// ReplicatorStatusChangedEventArgs.cs
// 
// Copyright (c) 2017 Couchbase, Inc All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using System;

using JetBrains.Annotations;
using LiteCore.Interop;

namespace Couchbase.Lite.Sync
{
    /// <summary>
    /// Event arguments for the <see cref="Replicator.AddChangeListener(EventHandler{ReplicatorStatusChangedEventArgs})" /> event
    /// </summary>
    public sealed class ReplicatorStatusChangedEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        /// The new status for the <see cref="Replicator"/> in question.
        /// </summary>
        public ReplicatorStatus Status { get; }

        #endregion

        #region Constructors

        internal ReplicatorStatusChangedEventArgs(ReplicatorStatus status)
        {
            Status = status;
        }

        #endregion
    }

    /// <summary>
    /// Event arguments for the <see cref="Replicator.AddBlobProgressListener(EventHandler{ReplicatorBlobProgressUpdatedEventArgs})" /> event
    /// </summary>
    public sealed class ReplicatorBlobProgressUpdatedEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        /// The new status for the <see cref="Replicator"/> in question.
        /// </summary>
        public BlobProgress Progress { get; }

        #endregion

        #region Constructors

        internal ReplicatorBlobProgressUpdatedEventArgs(BlobProgress progress)
        {
            Progress = progress;
        }

        #endregion
    }

    /// <summary>
    /// Event arguments for the <see cref="Replicator.AddDocumentEndedListener(EventHandler{ReplicatorDocumentReplicatedEventArgs})" /> event
    /// </summary>
    public sealed class ReplicatorDocumentReplicatedEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        /// The new status for the <see cref="Replicator"/> in question.
        /// </summary>
        public DocumentReplicatedStatus Status { get; }

        #endregion

        #region Constructors

        internal ReplicatorDocumentReplicatedEventArgs(DocumentReplicatedStatus status)
        {
            Status = status;
        }

        #endregion
    }
}
