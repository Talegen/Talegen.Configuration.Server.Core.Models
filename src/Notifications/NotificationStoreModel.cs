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

namespace Talegen.Configuration.Server.Core.Models.Notifications
{
    using System;
    using Types;

    /// <summary>
    /// This model represents a notification alert that has been stored in the user's store for load on UI/Profile startup.
    /// </summary>
    public class NotificationStoreModel
    {
        /// <summary>
        /// Gets or sets the Notification identity.
        /// </summary>
        public Guid NotificationId { get; set; }

        /// <summary>
        /// Gets or sets the client identity.
        /// </summary>
        public long ClientId { get; set; }

        /// <summary>
        /// Gets or sets the notification date.
        /// </summary>
        public DateTime NotificationDate { get; set; }

        /// <summary>
        /// Gets or sets the alert state of the notification.
        /// </summary>
        public NotificationMessageAlertStatus Alert { get; set; }

        /// <summary>
        /// Gets or sets the notification state.
        /// </summary>
        public NotificationState State { get; set; }

        /// <summary>
        /// Gets or sets the target type.
        /// </summary>
        public NotificationTarget Target { get; set; }

        /// <summary>
        /// Gets or sets the type of notification.
        /// </summary>
        public NotificationType Type { get; set; }

        /// <summary>
        /// Gets or sets the message model properties.
        /// </summary>
        public NotificationMessageModel Message { get; set; } = new NotificationMessageModel();
    }
}