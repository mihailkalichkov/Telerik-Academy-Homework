namespace CrowdChat.Data
{
    using System.Collections.ObjectModel;

    using CrowdChat.Models;

    public class ApplicationData
    {
        public ApplicationData(ObservableCollection<Message> messages)
        {
            this.Messages = messages;
        }

        public ApplicationData():this(new ObservableCollection<Message>())
        {

        }

        public ObservableCollection<Message> Messages { get; set; }
    }
}
