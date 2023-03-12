/*
 * Talegen Configuration Server
 * (c) Copyright Talegen, LLC.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace Talegen.Configuration.Server.Core.Models.Notifications.Types
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of available component action notifications.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationComponentAction
    {
        /// <summary>
        /// The specified component was added to the specified parent folder.
        /// </summary>
        Added,

        /// <summary>
        /// The specified component was updated.
        /// </summary>
        Updated,

        /// <summary>
        /// The specified component was removed.
        /// </summary>
        Removed
    }

    /// <summary>
    /// This class represents a folder notification message.
    /// </summary>
    public class NotificationConfigurationModel : NotificationModelBase
    {
        /// <summary>
        /// Gets or sets the specified folder unique identity.
        /// </summary>
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the specified folder action.
        /// </summary>
        public NotificationComponentAction Action { get; set; }

        /// <summary>
        /// Gets or sets the specified folder name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the specified folder path.
        /// </summary>
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the configuration contents changed.
        /// </summary>
        public string Contents { get; set; } = string.Empty;
    }
}