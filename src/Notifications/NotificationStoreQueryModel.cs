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
    using System.Collections.Generic;
    using Common.Models.Server.Queries;

    /// <summary>
    /// This class represents a notification store query model used in paging interfaces for notification messages.
    /// </summary>
    public class NotificationStoreQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedQueryRequestModel" /> class.
        /// </summary>
        public NotificationStoreQueryModel() : this(string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedQueryRequestModel" /> class.
        /// </summary>
        /// <param name="searchText">Sets the default search text within notifications.</param>
        public NotificationStoreQueryModel(string searchText)
        {
            this.SearchText = searchText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedQueryRequestModel" /> class.
        /// </summary>
        /// <param name="searchText">Contains the default search text within notifications.</param>
        /// <param name="maxPageSize">Contains the maximum page size.</param>
        /// <param name="currentPage">Contains an optional current page number.</param>
        public NotificationStoreQueryModel(string searchText, int maxPageSize, int currentPage = 1) : base(maxPageSize, currentPage)
        {
            this.SearchText = searchText;
        }

        /// <summary>
        /// Gets or sets a string used for filtering notification results.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets a list of states to filter by. An empty list will not filter by state.
        /// </summary>
        public List<NotificationState> State { get; set; } = new List<NotificationState>();

        /// <summary>
        /// Gets or sets a list of alerts to filter by. An empty list will not filter by alert.
        /// </summary>
        public List<NotificationMessageAlertStatus> Alert { get; set; } = new List<NotificationMessageAlertStatus>();
    }
}