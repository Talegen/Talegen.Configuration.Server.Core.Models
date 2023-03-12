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
    /// <summary>
    /// This class represents a message.
    /// </summary>
    public class NotificationMessageModel : NotificationModelBase
    {
        /// <summary>
        /// This class implements a message notification model.
        /// </summary>
        public NotificationMessageModel() : this(string.Empty, string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// This class implements a message notification model.
        /// </summary>
        /// <param name="subject">Contains the optional subject of the message.</param>
        /// <param name="summary">Contains a summary of the message.</param>
        /// <param name="body">Contains the full body of the message.</param>
        public NotificationMessageModel(string subject, string summary, string body)
        {
            this.Subject = subject;
            this.Summary = summary;
            this.Body = body;
        }

        /// <summary>
        /// Gets or sets the message subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the summary message to display to the user in notification toasts.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the message content body.
        /// </summary>
        public string Body { get; set; }
    }
}