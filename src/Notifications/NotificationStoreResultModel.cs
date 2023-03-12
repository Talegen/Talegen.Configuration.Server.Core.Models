﻿/*
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
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a notifications store query request.
    /// </summary>
    public class NotificationStoreResultModel
    {
        /// <summary>
        /// Gets or sets the total number of notifications for the user.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the total number of unread notification messages for the user.
        /// </summary>
        public long TotalUnreadCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting notifications from the query request.
        /// </summary>
        public List<NotificationStoreModel> Notifications { get; set; } = new List<NotificationStoreModel>();
    }
}